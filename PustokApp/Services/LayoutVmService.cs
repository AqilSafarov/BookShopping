using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using PustokApp.Models;
using PustokApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.Services
{
    public class LayoutVmService
    {
        private readonly AppDbContext _context;
        private readonly IHttpContextAccessor _contextAccessor;

        public LayoutVmService(AppDbContext context,IHttpContextAccessor contextAccessor)
        {
            _context = context;
            _contextAccessor = contextAccessor;
        }
        public List<Category> GetCategories()
        {
            List<Category> categories = _context.Categories.ToList();
            return categories;
        }
        public VmBasketCard GetBasket()
        {
            VmBasketCard basketVm = new VmBasketCard();
            var basket = _contextAccessor.HttpContext.Request.Cookies["basket"];
            List<BasketCardItemModel> basketCardItemsModel = new List<BasketCardItemModel>();


            if (basket!=null)
            {
                basketCardItemsModel = JsonConvert.DeserializeObject<List<BasketCardItemModel>>(basket);
            }

            foreach (var basketItem in basketCardItemsModel)
            {
                Book book = _context.Books.Include(x=>x.BookPhotos).FirstOrDefault(x => x.Id == basketItem.Id);
                 
                if (book==null)
                    continue;
                BasketBookItemViewModel basketItemVm = new BasketBookItemViewModel
                {
                    Id=basketItem.Id,
                    Count=basketItem.Count,
                    Name=book.Name,
                    Price=book.Price,
                    Poster=book.BookPhotos.FirstOrDefault(x=>x.PosterStatus==true)?.Name,
                };
                basketVm.TotalPrice += book.Price * basketItem.Count;
                basketVm.BasketBookItems.Add(basketItemVm);

            }

            return basketVm;
        }
       
    }
}
