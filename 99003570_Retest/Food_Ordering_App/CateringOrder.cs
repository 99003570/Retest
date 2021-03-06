

using System;
namespace Food_Ordering_App
{
    public class CateringOrder : Order
    {
        //setting some properties for the Catering class
   
        public double decDeliveryFee { get; set; }
        

        public double CheckoutCatering(int intFriesNum, int intBurgerNum, string strDeliveryFee, string strNameInput)
        {
            double decDeliveryFee1;
            //Boolean bolCustomerCode;
            decDeliveryFee1 = Validation.CheckDeliveryFee(strDeliveryFee);
            if (decDeliveryFee1 == -1)
            {
                return 0.1;
            }
            decDeliveryFee = decDeliveryFee1;
            CustomerType = CustomerType.CATERING;
            strCustomerName = strNameInput;
            intNumberOfFries = intFriesNum;
            intNumberOfBurger = intBurgerNum;
            intTotalItems = intFriesNum + intBurgerNum;
            decFriesubtotal = intFriesNum * decPriceFries;
            decBurgerSubtotal = intBurgerNum * decPriceSand;
            decSubtotal = decFriesubtotal + decBurgerSubtotal;
            decTotal = decSubtotal + (decTaxRate * decSubtotal)+ decDeliveryFee;
            //double res = CalcTotalsCat();
            return decTotal;
        }
        //calc total method to set delivery fee and to set a calculated total.
        //public double CalcTotalsCat()
        //{
     
        //    //calculates the total for the order
        //    decSalesTax = decTaxRate * decSubtotal;
        //    return decSubtotal + decDeliveryFee+ decSalesTax;

        //}

        //overriding the ToString Method
        public override string ToString()
        {
           
            return "Customer Type: " + CustomerType + "\n" + "Customer name: " + strCustomerName + "\n"
                + "Total Items: " + intTotalItems.ToString() + "\nFries Subtotal: " + decFriesubtotal.ToString() + "\nBurger Subtotal: " + decBurgerSubtotal.ToString()
                + "\nSubtotal: " + decSubtotal.ToString() + "\nDelivery Fee: " + decDeliveryFee.ToString() + "\nGrand Total: " + decTotal.ToString();

        }
      
    }
}
