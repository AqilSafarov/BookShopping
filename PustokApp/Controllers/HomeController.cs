using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokApp.View_Models;
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
                NewSliderBooks = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).Where(x => x.IsNew == false).Take(12).ToList(),
                DiscountedSliderBooks = _context.Books.Include(x => x.Author).Include(x => x.BookPhotos).Where(x => x.DiscountPercent > 0).Take(12).ToList()


            };
            return View(vmhome);
        }

      
    }
}
