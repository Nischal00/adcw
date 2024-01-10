using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cw.Data
{
    public class Coffee
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public bool Selected { get; set; }
        public List<AddOns> AddOns { get; set; } = new List<AddOns>();
        public decimal TotalPrice
        {
            get
            {
                return Price + AddOns.Sum(a=>a.AddOnPrice);
            }
        }
    }
    public class AddOns
    {
        public string Name { get; set; }
        public decimal AddOnPrice { get; set; }
    }

}

