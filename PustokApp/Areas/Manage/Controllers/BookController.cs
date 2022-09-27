using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokApp.Areas.Manage.ViewModels;
using PustokApp.Helpers;
using PustokApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Areas.Manage.Controllers
{
    [Area("Manage")]
    public class BookController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public BookController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index(int page=1)
        {
            double totalCount = await _context.Books.CountAsync();
            int pageCount= (int)Math.Ceiling(totalCount / 8);


            if (page < 1)
            {
                page = 1;
            }
            else if (page > pageCount)
            {
                page = pageCount;
            }
            ViewBag.PageCount = pageCount;
            ViewBag.SelectedPage = page;

            BookVm bookVm = new BookVm()
            {
                Books = await _context.Books.Include(x=>x.Author).Skip((page - 1) * 8).Take(8).ToListAsync(),
            };
            return View(bookVm);
        }
        public async Task<IActionResult> Create()
        {

            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Categories = _context.Categories.ToList();
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Book book)
        {
            #region CheckAuthorNotFound  
            if (!await _context.Authors.AnyAsync(x => x.Id == book.AuthorId))
            {
                ModelState.AddModelError("AuthorId", "Author is not available");
            }
            #endregion

            #region CheckCategoryNotFound
            if (!await _context.Categories.AnyAsync(x => x.Id == book.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Category is not found");
            }
            #endregion


            #region ChechkModelState
            if (!ModelState.IsValid)
            {
                ViewBag.Authors = _context.Authors.ToList();
                ViewBag.Categories = _context.Categories.ToList();

                return View();
            }
            #endregion

            if (book.DiscountPercent > 0)
            {
                book.DiscountedPrice = book.Price * (100 - book.DiscountPercent) / 100;
            }

            book.CratedAt = DateTime.UtcNow;
            book.CodePrefix = "BC";
            Book lastBook = await _context.Books.OrderByDescending(x => x.CodeNum).FirstOrDefaultAsync();
            book.CodeNum = lastBook == null ? 1001 : (lastBook.CodeNum + 1);


            book.BookPhotos = new List<BookPhoto>();

            if (book.Files !=null)
            {
                if (book.PosterFile==null)
                {
                    ModelState.AddModelError("PosterFile","Poster statusunu secmeden sekil daxil ede bilmersiz");
                }
                if (book.Files.Length>2)
                {
                    ModelState.AddModelError("Files","2 den cox sekil elave edile bilmez");
                }
                else
                {

                    int i=2;
                    foreach (var file in book.Files)
                    {

                        #region ChechkFileRange
                        if (file.Length > 2 * (1024 * 1024))
                        {
                            ModelState.AddModelError("File", "2 mq artiq ola bilmez");
                            return View();

                        }
                        #endregion

                        #region ChehckFileContentTye
                        if (file.ContentType != "image/png" && file.ContentType != "image/jpeg")
                        {
                            ModelState.AddModelError("File", "Image type duzgun deyil");
                            return View();

                        }
                        #endregion

                        string filename = FileManagerHelper.Save(_env.WebRootPath, "uploads/books", file);

                        BookPhoto bookPhoto = new BookPhoto()
                        {
                            Name = filename,
                            Book=book,
                            PosterStatus = false,
                            Order = i

                        };
                        i++;

                        book.BookPhotos.Add(bookPhoto);
                    }
                }

            }

            if (book.PosterFile!=null)
            {

                #region ChechkFileRange
                if (book.PosterFile.Length > 2 * (1024 * 1024))
                {
                    ModelState.AddModelError("File", "2 mq artiq ola bilmez");
                    return View();

                }
                #endregion

                #region ChehckFileContentTye
                if (book.PosterFile.ContentType != "image/png" && book.PosterFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("File", "Image type duzgun deyil");
                    return View();

                }
                #endregion

                string filename = FileManagerHelper.Save(_env.WebRootPath, "uploads/books", book.PosterFile);

                BookPhoto bookPhoto = new BookPhoto()
                {
                    Name = filename,
                    Book = book,
                    PosterStatus = true,
                    Order = 1

                };

                book.BookPhotos.Add(bookPhoto);
            }

            #region CheckModelState
            if (!ModelState.IsValid)
            {
                ViewBag.Authors = _context.Authors.ToList();
                ViewBag.Categories = _context.Categories.ToList();

                return View();
            }
            #endregion


            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Edit(int id)
        {
            Book book = await _context.Books.Include(x=>x.BookPhotos).FirstOrDefaultAsync(x=>x.Id==id);
            ViewBag.Authors = _context.Authors.ToList();
            ViewBag.Categories = _context.Categories.ToList();

            #region CheckAuthorNotFound  
            if (book==null)
            {
                return NotFound();
            }
            #endregion
            return View(book);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(Book book)
        {

            Book exsitBook = await _context.Books.Include(x => x.BookPhotos).FirstOrDefaultAsync(x => x.Id == book.Id);

            if (exsitBook==null)
            {
                return NotFound();
            }
            #region CheckAuthorNotFound  
            if (!await _context.Authors.AnyAsync(x => x.Id == book.AuthorId))
            {
                ModelState.AddModelError("AuthorId", "Author is not available");
            }
            #endregion

            #region CheckCategoryNotFound
            if (!await _context.Categories.AnyAsync(x => x.Id == book.CategoryId))
            {
                ModelState.AddModelError("CategoryId", "Category is not found");
            }
            #endregion


            #region ChechkModelState
            if (!ModelState.IsValid)
            {
                ViewBag.Authors = _context.Authors.ToList();
                ViewBag.Categories = _context.Categories.ToList();

                return View();
            }
            #endregion

            exsitBook.Name = book.Name;
            exsitBook.Desc = book.Desc;
            exsitBook.IsAvailable = book.IsAvailable;
            exsitBook.IsNew = book.IsNew;
            exsitBook.Price = book.Price;
            exsitBook.DiscountPercent = book.DiscountPercent;
            exsitBook.AuthorId = book.AuthorId;
            exsitBook.CategoryId = book.CategoryId;
            exsitBook.DiscountedPrice= book.Price * (100 - book.DiscountPercent) / 100;


            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }
    }
}
