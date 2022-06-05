using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaWepCoreApp.DAL;
using ProniaWepCoreApp.ViewModel;
using System.Linq;

namespace ProniaWepCoreApp.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context { get; }
        public HomeController(AppDbContext opt)
        {
            _context = opt;
        }
        // GET: HomeController 
        public ActionResult Index()
        {
            HomeVM homeVM = new HomeVM()
            {
                sliders = _context.Sliders.ToList(),
                categories = _context.categories.ToList(),
                products = _context.Products.Where(p=>p.IsDeleted == false).Include(p => p.category).Include(p => p.PImages).ToList(),

        };
            return View(homeVM);
        }
    }
}
