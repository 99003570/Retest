using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Food_Ordering_App
{
    public class PickUpOrder : Order
    {
        //setting some properties for the PickUp class
   
        public double DeliveryFee { get; set; }
          public double CheckoutPickUp(int intFriesNum, int intBurgerNum, string strDeliveryFee, string strNameInput)
        {
            double DeliveryFee1;
            //Boolean bolCustomerCode;
            DeliveryFee1 = Validation.CheckDeliveryFee(strDeliveryFee);
            if (DeliveryFee1 == -1)
            {
                return 0.1;
            }
            DeliveryFee = DeliveryFee1;
            CustomerType = CustomerType.PICKUP;
            strCustomerName = strNameInput;
            intNumberOfFries = intFriesNum;
            intNumberOfBurger = intBurgerNum;
            intTotalItems = intFriesNum + intBurgerNum;
           Friessubtotal = intFriesNum * PriceFries;
            BurgerSubtotal = intBurgerNum * PriceBurger;
            Subtotal =Friessubtotal + BurgerSubtotal;
            decTotal = Subtotal + (TaxRate * Subtotal)+ DeliveryFee;
            return decTotal;
        }
        
        public override string ToString()
        {
           
            return "Customer Type: " + CustomerType + "\n" + "Customer name: " + strCustomerName + "\n"
                + "Total Items: " + intTotalItems.ToString() + "\nFries Subtotal: " +Friessubtotal.ToString() + "\nBurger Subtotal: " + BurgerSubtotal.ToString()
                + "\nSubtotal: " + Subtotal.ToString() + "\nDelivery Fee: " + DeliveryFee.ToString() +"\nTotalTax "+(TaxRate *Subtotal)+ "\nGrand Total: " + decTotal.ToString();

        }
      
    }
}
