using System.Collections.Generic;

namespace ProniaWepCoreApp.Models
{
    public class Color
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ProductColor> ProductColor { get; set; }

    }
}
