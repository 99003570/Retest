using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Ordering_App
{
    public class Validation
      {  
        //method to check Customer Type
        public Boolean CheckCustomerType(String strInput)
        {
            //force to upper case
            strInput = strInput.ToUpper();

            //see if value is in enum
            return Enum.IsDefined(typeof(CustomerType), strInput);
        }

        //method to check if a parameter is a positive number only no symbols. For use when user is PickUp
        public static double CheckDeliveryFee(String strInput)
        {
            //declaring a double   
            double decResult;
            try { 
                decResult = Convert.ToDouble(strInput);
            }
            catch
            { 
                return -1;
            }
            //checking the value to make sure we get positive returns only
            if (decResult < 0)
            { 
                return -1;
            }

            return decResult;
        }

        //method to check the number of items and if it is positive with no symbols.
        public static int CheckItem(String strInput)
        {
            //declaring an int

            int intResult;
            try 
            { 
                intResult = Convert.ToInt32(strInput);
            }
            catch 
            {
                return -1; 
            }
            //checking the value to make sure we get positive returns only
            if (intResult < 0) 
            { 
                return -1; 
            }

            return intResult;
        }


    }
}
