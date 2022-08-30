using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PustokApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp
{
    public class AppDbContext: IdentityDbContext
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookPhoto> BookPhotos { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Partner> Partners { get; set; }
        public DbSet<Promotion> Promotions { get; set; }

    }
}
