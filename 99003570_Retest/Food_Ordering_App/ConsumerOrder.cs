using System;
namespace Food_Ordering_App
{
    public class ConsumerOrder : Order
     {

        public double CheckoutConsumer(int intFriesNum, int intBurgerNum, string strNameInput)
        {
            //string strNameInput;
            CustomerType = CustomerType.CONSUMER;
            strCustomerName = strNameInput;
            intNumberOfFries = intFriesNum;
            intNumberOfBurger = intBurgerNum;
            intTotalItems = intFriesNum + intBurgerNum;
            decFriesubtotal = intFriesNum * decPriceFries;
            decBurgerSubtotal = intBurgerNum * decPriceSand;
            decSubtotal = decFriesubtotal + decBurgerSubtotal;

            double res1 = CalcTotalsCon();
            return res1;
        }

        //method to calculate the totals for sales tax and the total
        public double CalcTotalsCon()
        {
            decSalesTax = decTaxRate * decSubtotal;
            return decSubtotal + decSalesTax;
        }

        //overriding the ToString Method for this class
        public override string ToString()
        {
            return "Customer Type: " + CustomerType + "\n" + "Customer name: " + strCustomerName + "\n"
                + "Total Items: " + intTotalItems.ToString() + "\nFries Subtotal: " + decFriesubtotal.ToString() + "\nBurger Subtotal: " + decBurgerSubtotal.ToString()
                + "\nSubtotal: " + decSubtotal.ToString() + "\nSales Tax: " + decSalesTax.ToString() + "\nGrand Total: " + CalcTotalsCon().ToString();
        }
    }
}
