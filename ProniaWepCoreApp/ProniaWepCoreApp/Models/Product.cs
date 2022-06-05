using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProniaWepCoreApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public double? Price { get; set; }
        public int? Raiting { get; set; }
        public int? StockCount { get; set; }
        public string? Description { get; set; }
        public bool? IsDeleted  { get; set; } = false;
        public int? CategoryId { get; set; }
        public Category category { get; set; }
        public List<ProductImages> PImages { get; set; }
        public List<ProductColor> PColor { get; set; }
        [NotMapped]
        public IFormFileCollection Photos { get; set;  }
        [NotMapped]
        public IFormFile MainPhoto { get; set; }
        [NotMapped]
        public List<int> ImageIds { get; set; }
        [NotMapped]
        public List<int> CategoryIds { get; set; }
    }
}
