using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PustokApp.Models;
using PustokApp.View_Models;
using PustokApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Controllers
{
    public class BookController : Controller
    {
        private readonly AppDbContext _context;

        public BookController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int page = 1, int? categoryId = null)
        {
            decimal pageCount = _context.Books.Where(x => (categoryId != null ? x.CategoryId == categoryId : true)).Count() / 4m;
            VmBook bookVm = new VmBook
            {
                Categories = _context.Categories.ToList(),
            };
            ViewBag.SelectedPage = page;
            ViewBag.PageCount = (int)Math.Ceiling(pageCount);
            ViewBag.CategoryId = categoryId;

            return View(bookVm);
        }
        public IActionResult AddBasket(int id)
        {
            Book book = _context.Books.FirstOrDefault(x => x.Id == id);
            if (book==null)
            {
                return NotFound();
            }
            List<BasketCardItemModel> basketItem = new List<BasketCardItemModel>();

            if (Request.Cookies["basket"]==null)
            {
                //basketCardVm.TotalPrice = book.Price;
                BasketCardItemModel basketCardItemModel = new BasketCardItemModel
                {
                    Id = id,
                    Count = 1
                };
                basketItem.Add(basketCardItemModel);
            }
            else
            {
                basketItem = JsonConvert.DeserializeObject <List<BasketCardItemModel>>(Request.Cookies["basket"]);
                //basketCardVm.TotalPrice += book.Price;

                if (basketItem.Any(b=>b.Id==id))
                {
                    BasketCardItemModel basketBasketItem = basketItem.FirstOrDefault(x => x.Id == id);
                    basketBasketItem.Count += 1;
                }
                else
                {
                    BasketCardItemModel basketCardItemModel = new BasketCardItemModel
                    {
                        Id = id,
                        Count = 1
                    };
                    basketItem.Add(basketCardItemModel);
                }
            }
          
            
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketItem),new CookieOptions {MaxAge=TimeSpan.FromDays(1)});

            return RedirectToAction("index");
        }


        public IActionResult DeleteBasket(int id)
        {
            List<BasketCardItemModel> basketItem = new List<BasketCardItemModel>();
            BasketCardItemModel basketCardItemModel = new BasketCardItemModel();

            basketItem = JsonConvert.DeserializeObject<List<BasketCardItemModel>>(Request.Cookies["basket"]);

            if (basketItem.Any(b => b.Id == id))
            {
                BasketCardItemModel basketBasketItem = basketItem.FirstOrDefault(x => x.Id == id);
                if (basketBasketItem.Count>1)
                {
                    basketBasketItem.Count -= 1;

                }
                else
                {
                    basketItem.Remove(basketBasketItem);

                }
            }
            Response.Cookies.Append("basket", JsonConvert.SerializeObject(basketItem), new CookieOptions { MaxAge = TimeSpan.FromDays(1) });

            return RedirectToAction("index");
        }
        public IActionResult Basket()
        {
            var basket = Request.Cookies["basket"];
            List<BasketCardItemModel> basketItems = new List<BasketCardItemModel>();
            if (basket!=null)
            {
                basketItems = JsonConvert.DeserializeObject<List<BasketCardItemModel>>(basket);

            }
            return Json(basketItems);
        }


    }
}
