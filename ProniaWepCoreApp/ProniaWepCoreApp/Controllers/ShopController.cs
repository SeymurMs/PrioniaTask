using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaWepCoreApp.DAL;
using ProniaWepCoreApp.Models;
using System.Linq;

namespace ProniaWepCoreApp.Controllers
{
    public class ShopController : Controller
    {
        private AppDbContext _context { get; }
        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IQueryable<Product> products = _context.Products.Where(p=>p.IsDeleted== false).AsQueryable();
            ViewBag.ProductCount =products.Count();
            return View(_context.Products.Where(p => p.IsDeleted == false).Take(4).Include(pi => pi.PImages).Include(p => p.category).ToList());
          
        }
        public IActionResult LoadMore(int skip=0)
        {
            return PartialView("_ProductPartial",_context.Products.Where(p => p.IsDeleted == false).Skip(skip).Take(4).Include(pi => pi.PImages).Include(p => p.category));
        }
    }
}
