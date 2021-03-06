using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Food_Ordering_App
{
    public  class Order
    {
        //declaring constants
        public const double PriceFries = 10.00;
        public const double PriceBurger = 30.00;
        
        public const double TaxRate = 0.10;

        //creating the properties for the class
        public string strCustomerName { get; set; }
        public CustomerType CustomerType { get; set; }
        public int intNumberOfBurger { get; set; }
        public int intNumberOfFries { get; set; }
        public double Friessubtotal { get; set; }
        public double BurgerSubtotal { get; set; }
        public double Subtotal { get; set; }
        public double decTotal { get; set; }
        public int intTotalItems { get; set; }
        public double SalesTax { get; set; } 
    }
}
