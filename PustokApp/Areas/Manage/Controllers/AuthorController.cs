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
    public class AuthorController : Controller
    {
        private readonly AppDbContext _context;

        public AuthorController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(int page=1)
        {
            double totalCount = await _context.Authors.CountAsync();
            int pageCount = (int)Math.Ceiling(totalCount / 2);
          

            if (page<1)
            {
                page = 1;
            }
            else if (page>pageCount)
            {
                page = pageCount;
            }
            ViewBag.PageCount = pageCount;
            ViewBag.SelectedPage = page;
            AuthorVm authorVm = new AuthorVm
            {
                Authors = await _context.Authors.Skip((page - 1) * 2).Take(2).ToListAsync(),
            };
            return View(authorVm);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Author author)
        {


            #region ChechkAuthorAlreadyExsit
            if (await _context.Authors.AnyAsync(a => a.Fullname.ToLower() == author.Fullname.ToLower()))
            {
                ModelState.AddModelError("Fullname", "Bu adli yazici movcut deyil");
                return View();
            }
            #endregion

            #region ModelSatate
            if (!ModelState.IsValid)
            {
                return View(author);

            }
            #endregion


            //if (author.File != null)
            //{
            //    #region ChehckFileRaneg


            //    //    if (author.File.Length > 2 * (1024 * 1024))
            //    //    {
            //    //        ModelState.AddModelError("File", "2 mq artiq ola bilmez");
            //    //return View();
            //    //    }
            //    #endregion

            //    #region ChechkFileContentType
            //    //    if (author.File.ContetntType != "img/png" && author.File.ContetntType != "img/jpeg")  //ferlidirse png ve jpeg den addmodelerrrora duwsun
            //    //    {
            //    //        ModelState.AddModelError("File", "Image type duzgun deyil");
            //    //return View();


            //    //    }
            //    #endregion


            //}


            await _context.Authors.AddAsync(author);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(int id)
        {
            Author author = await _context.Authors.FirstOrDefaultAsync(x=>x.Id==id);

            #region ChechkAuthorNotFoudn
            if (author == null)
            {
                return NotFound();
            }
            #endregion

            return View(author);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Edit(Author author)
        {
            Author exsitAuthor = await _context.Authors.FirstOrDefaultAsync(x => x.Id == author.Id);

            #region ChechkAuthorNotFoudn
            if (exsitAuthor == null)
            {
                return NotFound();


            }

            #endregion


            //if (author.File != null)
            //{
            //    #region ChehckFileRaneg


            //    //    if (author.File.Length > 2 * (1024 * 1024))
            //    //    {
            //    //        ModelState.AddModelError("File", "2 mq artiq ola bilmez");
            //    //return View();
            //    //    }
            //    #endregion

            //    #region ChechkFileContentType
            //    //    if (author.File.ContetntType != "img/png" && author.File.ContetntType != "img/jpeg")  //ferlidirse png ve jpeg den addmodelerrrora duwsun
            //    //    {
            //    //        ModelState.AddModelError("File", "Image type duzgun deyil");
            //    //return View();


            //    //    }
            //    #endregion

            //string filename=FileManagerHelper.Save(_env.WebRootPath,"oploads/authors",author.File);
            //if (!string.IsNullOrWhiteSpace(exsitAuthor.Photo))
            //{
            //    FileManagerHelper.Delete(_env.WebRootPath, "oploads/authors", exsitAuthor.Photo);
            //}
            //exsitAuthor.Photo = filename;

            //}
            //else if (string.IsNullOrWhiteSpace(author.Photo))
            //{
            //    FileManagerHelper.Delete(_env.WebRootPath, "oploads/authors", exsitAuthor.Photo);


            //    //exsitAuthor.Photo = null;

            //}

            exsitAuthor.Fullname = author.Fullname;
            exsitAuthor.Desc = author.Desc;

            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        //public async Task<IActionResult> Delete(int id)
        //{
        //    Author author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
        //    #region ChechkAuthorNotFoudn
        //    if (author == null)
        //    {
        //        return NotFound();
        //    }
        //    #endregion

        //    return View(author);
        //}
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeletePost(int id)
        //{
        //    Author author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
        //    #region ChechkAuthorNotFoudn
        //    if (author == null)
        //    {
        //        return NotFound();
        //    }
        //    #endregion

        //    _context.Authors.Remove(author);
        //    _context.SaveChanges();

        //    return RedirectToAction("index");
        //}

        public async Task<IActionResult> Delete(int id)
        {
            Author author = await _context.Authors.FirstOrDefaultAsync(x => x.Id == id);
            #region ChechkAuthorNotFoudn
            if (author == null)
            {
                return NotFound();
            }
            #endregion



            _context.Authors.Remove(author);
            _context.SaveChanges();
            return Ok();
        }


    }
}
