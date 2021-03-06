
using System;
namespace Food_Ordering_App
{
    public  class Order
    {
        //declaring constants

        
        
        public const double decPriceFries = 10.00;
        public const double decPriceSand = 30.00;
        
        public const double decTaxRate = 0.10;



        //creating the properties for the class
        public string strCustomerName { get; set; }
        public CustomerType CustomerType { get; set; }
        public int intNumberOfBurger { get; set; }
        public int intNumberOfFries { get; set; }
        public double decFriesubtotal { get; set; }
        public double decBurgerSubtotal { get; set; }
        public double decSubtotal { get; set; }
        public double decTotal { get; set; }
        public Int32 intTotalItems { get; set; }
        public double decSalesTax { get; set; }

        //blank constructor
      //  public Order() { }


        //constructor for the class with customer type parameter
        //public Order(CustomerType customertypeInput)
        //{
        //    CustomerType customer_type = customertypeInput;

        //}

        //method for calculating the total is abstract
        //blank because subclass contains the implementations
       // public abstract double CalcTotals();
    }
}
