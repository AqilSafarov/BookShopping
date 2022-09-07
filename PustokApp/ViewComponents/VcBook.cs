using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PustokApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.ViewComponents
{
    public class VcBook:ViewComponent
    {
        private readonly AppDbContext _context;

        public VcBook(AppDbContext context)
        {
            _context = context;
        }
        public IViewComponentResult Invoke(int page=1,int? categoryId=null)
        {
            List<Book> books = _context.Books.Where(x=>(categoryId!=null? x.CategoryId==categoryId:true)).Include(x => x.BookPhotos).Include(x => x.Author).Skip((page - 1) * 4).Take(4).ToList();
            return View(books);
        }
    }
}
