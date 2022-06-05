using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaWepCoreApp.DAL;
using ProniaWepCoreApp.Models;
using ProniaWepCoreApp.utilize;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProniaWepCoreApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private AppDbContext _context { get; }
        private IWebHostEnvironment _env { get; }
        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.ToListAsync();

            return View(sliders);
        }
        public IActionResult Create()
        {

            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();
            Slider dbSld = _context.Sliders.FirstOrDefault(s => s.Title.ToLower().Trim().Contains(slider.Title.ToLower().Trim()));
            string fileName = Guid.NewGuid().ToString() + slider.Photo.FileName;
            if (slider.Photo != null)
            {
                
                slider.Image = slider.Photo.SaveImg(_env.WebRootPath, "upload", fileName);
            }

            slider.Image = fileName;
            await _context.Sliders.AddAsync(slider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index)); 
        }
 
        public IActionResult Delete(int? id)
        {
            Slider slider = _context.Sliders.Find(id);
            if (slider == null) return NotFound();
            FileManage.DeleteFile(Path.Combine(_env.WebRootPath, "upload", slider.Image));
            _context.Sliders.Remove(slider);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
        public IActionResult Update(int? id)
        {
            Slider slider = _context.Sliders.Find(id);
            if (slider == null)
            {
                return NotFound();
            }
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int? id , Slider slider)
        {
            if (slider.Id != id)
            {
                return BadRequest();
            }
            Slider SliItem = _context.Sliders.Find(id);
            if (SliItem == null)
            {
                return BadRequest();
            }
            string fileName = Guid.NewGuid().ToString() + slider.Photo.FileName;
            slider.Image = slider.Photo.SaveImg(_env.WebRootPath, "upload", fileName);


            SliItem.Title = slider.Title;
            SliItem.DiscountPercent = slider.DiscountPercent;
            SliItem.Image = slider.Image;
            SliItem.Description = slider.Description;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));

        }
    }
}
