using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaWepCoreApp.DAL;
using ProniaWepCoreApp.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaWepCoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CategoryController : Controller
    {
        private AppDbContext _context { get; }
        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        // GET: CategoryController
        public async Task<ActionResult> Index()
        {
            List<Category> categories = await _context.categories.ToListAsync();
            return View(categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Category category)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Category DbCategoty = _context.categories.FirstOrDefault(c => c.Name.ToLower().Trim().Contains(category.Name.ToLower().Trim()));

            _context.categories.Add(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            Category category = _context.categories.Find(id);
            if (category == null)
            {
                return BadRequest();
            }
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            if (category.Id != id)
            {
                return BadRequest();
            }
            Category DbCategory = _context.categories.Find(id);
            if (DbCategory == null)
            {
                return BadRequest();
            }
            DbCategory.Name = category.Name;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));


        }

        public ActionResult Delete(int id)
        {
            Category category = _context.categories.Find(id);
            if (category == null)
            {
                return BadRequest();
            }
            _context.categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
