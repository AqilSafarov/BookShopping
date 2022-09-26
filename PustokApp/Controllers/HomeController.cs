using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PustokApp.Enums;
using PustokApp.Models;
using PustokApp.View_Models;
using System.Collections.Generic;
using System.Linq;

namespace PustokApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            VmHome vmhome = new VmHome()
            {
                Sliders = _context.Sliders.OrderBy(x => x.Order).ToList(),
                Features = _context.Features.OrderBy(x => x.Order).Take(4).ToList(),
                Promotions = _context.Promotions.Take(2).ToList(),
                AllSliderBooks = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).OrderByDescending(x=>x.CratedAt).Take(12).ToList(),
                NewSliderBooks = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).Where(x => x.IsNew).OrderByDescending(x=>x.CratedAt).Take(12).ToList(),
                DiscountedSliderBooks = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).Where(x => x.DiscountPercent > 0).OrderByDescending(x=>x.CratedAt).Take(12).ToList()


            };
            return View(vmhome);
        }

        public IActionResult GetSliderBooks(BookSliderTabType? type=null)
        {
            List<Book> books = _context.Books.ToList();
            switch (type)
            {
               
                case BookSliderTabType.New:
                    books = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).Where(x => x.IsNew).OrderByDescending(x => x.CratedAt).Take(12).ToList();
                    break;
                case BookSliderTabType.Discounted:
                    books = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).Where(x => x.DiscountPercent > 0).OrderByDescending(x => x.CratedAt).Take(12).ToList();
                    break;
                default:
                    books = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).OrderByDescending(x => x.CratedAt).Take(12).ToList();
                    break;
            }
            return Json(books);
            //return PartialView("_BookSliderPartial", books);
        }

        public IActionResult BookSliderCardPartial(BookSliderTabType? type = null)
        {
            List<Book> books = _context.Books.ToList();
            switch (type)
            {

                case BookSliderTabType.New:
                    books = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).Where(x => x.IsNew).OrderByDescending(x => x.CratedAt).Take(12).ToList();
                    break;
                case BookSliderTabType.Discounted:
                    books = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).Where(x => x.DiscountPercent > 0).OrderByDescending(x => x.CratedAt).Take(12).ToList();
                    break;
                default:
                    books = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).OrderByDescending(x => x.CratedAt).Take(12).ToList();
                    break;
            }
            return PartialView("_BookSliderCardPartial", books);

        }



    }
}
