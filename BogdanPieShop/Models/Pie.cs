using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BogdanPieShop.Models
{
    public class Pie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string ImageThumbnailUrl { get; set; }
        public bool IsPieOfWeek { get; set; }

        public override string ToString()
        {
            return "Pie [ Id = " + Id + " ]";
        }
    }
}
