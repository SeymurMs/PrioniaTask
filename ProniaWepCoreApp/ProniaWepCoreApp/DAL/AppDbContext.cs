using Microsoft.EntityFrameworkCore;
using ProniaWepCoreApp.Models;
using System.Collections.Generic;

namespace ProniaWepCoreApp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions opt):base(opt)
        {
        }
        public DbSet<Slider>Sliders { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<ProductColor> ProductColors { get; set; }
        public DbSet<ProductImages> productImages { get; set; }
        public DbSet<Category> categories { get; set; }
    }
}
