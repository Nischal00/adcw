using System;
using System.Collections.Generic;
using System.Linq;

namespace Cw.Data
{
   

    public class SimpleOrder
    {

        public DateTime DateTime { get; set; }
        public decimal Price { get; set; }
        
        public string PhoneNumber { get; set; }
        public List<CoffeeDetails> Coffees { get; set; }
    }
    internal class AllOrdersList
    {
        public List<SimpleOrder> AllOrders { get; set; }
        public AllOrdersList()
        {
            this.AllOrders = new();
        }
    }

    public class CoffeeDetails
    {
        public string CoffeeName { get; set; }
        public string Addon { get; set; }
        public decimal Price { get; set; }
    }

  
}
