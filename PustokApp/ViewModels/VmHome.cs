using PustokApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PustokApp.View_Models
{
    public class VmHome
    {
        public List<Slider> Sliders { get; set; }
        public List<Feature> Features { get; set; }
        public List<Promotion> Promotions { get; set; }

        public List<Book> DiscountedSliderBooks { get; set; }
        public List<Book> NewSliderBooks { get; set; }
        public List<Book> AllSliderBooks { get; set; }
    }
}
