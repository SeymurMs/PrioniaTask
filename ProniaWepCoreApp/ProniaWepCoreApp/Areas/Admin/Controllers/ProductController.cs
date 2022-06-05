using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
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
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;
        private IWebHostEnvironment _env { get; }

        public ProductController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env; 
        }
        public ActionResult Index()
        {
            List<Product> products = _context.Products.Include(p=>p.category).Include(p=>p.PImages).ToList();
            return View(products);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        public ActionResult Create()
        {
            ViewBag.Categories = _context.categories.ToList();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product product)
        {
            ViewBag.Categories = _context.categories.ToList();
            if (!ModelState.IsValid)
            {
                return View();
            }
            if (_context.Products.Any(p => p.Title == product.Title))
            {
                return View();
            }
            product.PImages = new List<ProductImages>();
            foreach (var item in product.Photos)
            {
                string fileName = Guid.NewGuid().ToString() + item.FileName;

                ProductImages Pimage = new ProductImages
                {
                    Image = item.SaveImg(_env.WebRootPath, "products", fileName),
                    IsMain = false,
                    product = product
                };
                product.PImages.Add(Pimage);

            }
            
            string mainFileName = Guid.NewGuid().ToString() + product.MainPhoto.FileName;
            product.PImages.Add(new ProductImages
            {
                Image = product.MainPhoto.SaveImg(_env.WebRootPath, "products", mainFileName  ),
                IsMain = true,
                product = product

            });
           product.IsDeleted = false;
           await _context.Products.AddAsync(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public ActionResult Edit(int id)
        {
            Product Product = _context.Products.Include(p => p.category).Include(pi => pi.PImages).SingleOrDefault(p=>p.Id == id);
            ViewBag.Categories = _context.categories.ToList();
            return View(Product);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Product product)
        {
            if (product.Id != id)
            {
                return BadRequest();
            }
            Product DbProduct = _context.Products.Find(id);
            List<ProductImages> productImages = _context.productImages.Where(pi=>pi.ProductId == id).ToList();
            List<Category> categories = _context.categories.Where(c => c.Id == product.CategoryId).ToList();
            List<int> Ids = new List<int>();
            if (DbProduct == null)
            {
                return BadRequest();
            }

         
                foreach (var item in productImages.Where(pi=>pi.IsMain == false))
                {
                    bool isTrue = false;
                    foreach (var imgId in product.ImageIds)
                    {
                        if (item.Id == imgId)
                        {
                            isTrue = true;
                            break;
                        }
                        if (isTrue == false)
                        {
                            Ids.Add(item.Id);
                            break;
                        }
                    }
            }
           
                foreach (int item in Ids)
                {
                FileManage.DeleteFile(Path.Combine(_env.WebRootPath, "products", productImages.Find(pi => pi.Id == item).Image));
                productImages.Remove(productImages.Find(pi => pi.Id == item));
                }
                if (product.Photos != null)
                {
                ProductImages pImg = new ProductImages();

                    foreach (var item in product.Photos)
                    {
                            string fileName = Guid.NewGuid().ToString() + item.FileName;

                            pImg.Image = item.SaveImg(Path.Combine(_env.WebRootPath), "products", fileName);
                            pImg.IsMain = false;
                            pImg.product = DbProduct;
                    }
                string MainfileName = Guid.NewGuid().ToString() + product.MainPhoto.FileName;

                product.PImages.Add(new ProductImages
                {
                    IsMain = true,
                    Image = product.MainPhoto.SaveImg(Path.Combine(_env.WebRootPath), "products", MainfileName),
                    product = DbProduct

                }); 
                }

                    DbProduct.Price = product.Price;
                    DbProduct.Raiting = product.Raiting;
                    DbProduct.Title = product.Title;
                    DbProduct.StockCount = product.StockCount;
                    DbProduct.Description = product.Description;
                    DbProduct.PImages = productImages;
                    DbProduct.category = categories[0];
                    _context.SaveChanges();
                    return RedirectToAction("Index");
        }

      
    
        public ActionResult Delete(int id)
        {
            Product dbProduct = _context.Products.Find(id);

            if (dbProduct == null)
            {
                return BadRequest();
            }
            _context.Products.Find(id).IsDeleted = true;
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
