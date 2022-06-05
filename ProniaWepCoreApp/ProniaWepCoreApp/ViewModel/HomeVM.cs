using ProniaWepCoreApp.Models;
using System.Collections.Generic;

namespace ProniaWepCoreApp.ViewModel
{
    public class HomeVM
    {
        public List<Slider> sliders { get; set; }
        public List<Category> categories { get; set; }
        public List<Product> products { get; set; }
        
    }
}
