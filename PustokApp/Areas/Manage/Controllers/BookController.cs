using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokApp.Areas.Manage.ViewModels;
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

        public BookController(AppDbContext context)
        {
            _context = context;
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


            await _context.Books.AddAsync(book);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");

        }
        public async Task<IActionResult> Edit(int id)
        {
            Book book = await _context.Books.FirstOrDefaultAsync(x=>x.Id==id);
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

            Book exsitBook = await _context.Books.FirstOrDefaultAsync(x => x.Id == book.Id);

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
