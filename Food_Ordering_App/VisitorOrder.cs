using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Food_Ordering_App
{
    public class VisitorOrder : Order
     {

        public double CheckoutVisitor(int intFriesNum, int intBurgerNum, string strNameInput)
        {
            //string strNameInput;
            
            CustomerType = CustomerType.VISITOR;
            strCustomerName = strNameInput;
           intNumberOfFries = intFriesNum;
            intNumberOfBurger = intBurgerNum;
            intTotalItems = intFriesNum + intBurgerNum;
           Friessubtotal = intFriesNum * PriceFries;
            BurgerSubtotal = intBurgerNum * PriceBurger;
            Subtotal =Friessubtotal + BurgerSubtotal;
            decTotal = Subtotal + (TaxRate * Subtotal);
            return decTotal;
        }
        //overriding the ToString Method for this class
        public override string ToString()
        {
            return "Customer Type: " + CustomerType + "\n" + "Customer name: " + strCustomerName + "\n"
                + "Total Items: " + intTotalItems.ToString() + "\nFries Subtotal: " +Friessubtotal.ToString() + "\nBurger Subtotal: " + BurgerSubtotal.ToString()
                + "\nSubtotal: " + Subtotal.ToString() + "\nTotalTax " + (TaxRate * Subtotal) + "\nGrand Total: " + decTotal.ToString();
        }
    }
}
