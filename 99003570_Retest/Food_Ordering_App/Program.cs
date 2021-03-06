
using System.Text.RegularExpressions;
using System;
using System.Linq;

namespace Food_Ordering_App
{
    public enum CustomerType { CONSUMER, CATERING };
    class Program
    {
        public static void Main(string[] args)
        {
            //declaring constants

            const double decPriceFries = 10.00;
            const double decPriceSand = 30.00;
           

        //declaring variables for input
        string strCustomerCodeInput;
            string strFries;
            Int32 intFries;
            string strSand;
            Int32 intBurger;
            Int32 intCountItems;
            string strDeliveryFee;
            int intFriesNum;
            string strNameInput;
            //Console.WriteLine("Enter number of burger");
            int intBurgerNum;
            CateringOrder CaterObj = new CateringOrder();
            ConsumerOrder obj = new ConsumerOrder();
            Validation VObj = new Validation();

            //declaring Boolean variable for customer type and positive number validation
            Boolean bolCustomerType;

            //Get customer type from the user with a while post validation loop
            do
            {
                //Ask for the Customer Type
                Console.WriteLine("Which type of order would you like to process <CONSUMER or CATERING>?");
                strCustomerCodeInput = Console.ReadLine().ToUpper();

                //calling validation method to validate the users input on type of customer
                bolCustomerType = VObj.CheckCustomerType(strCustomerCodeInput);

                //prints error message if the customer enters incorrect value for type of customer
                if (bolCustomerType == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid customer type. Please enter either 'Consumer' or 'Catering'. ");
                    Console.WriteLine("");
                }
            } while (bolCustomerType == false);

            //get customer input for number of Fries/Burger while validating that they ordered at least one item
            do
            {
                // start the order process
                intCountItems = 0;

                //Fries order loop
                do
                {
                    //asks user for input
                    Console.WriteLine("How Many Fries would you like?:");
                    strFries = Console.ReadLine();

                    //call check positive to make sure order amount is a correct format
                    intFries = Validation.CheckItem(strFries);

                    //Fries error message
                    if (intFries == -1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Invalid Fries Order Amount. Please Order in whole number intervals with no special symbols.");
                        Console.WriteLine("");
                    }

                    //keep order count to make sure they order at least one item
                    else if (intFries != -1)
                    { 
                        intCountItems = intCountItems + intFries;
                    }

                    //inserts blank line for readability
                    Console.WriteLine("");

                } while (intFries == -1);

                //Burger order loop
                do
                {
                    //asks user for input
                    Console.WriteLine("How Many Burger would you like?:");
                    strSand = Console.ReadLine();

                    //call check positive to make sure order amount is a correct format
                    intBurger = Validation.CheckItem(strSand);

                    //Burger error message
                    if (intBurger == -1)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Invalid Burger Order Amount. Please Order in whole number intervals with no special symbols.");
                        Console.WriteLine("");
                    }

                    //keep order count to make sure they order at least one item
                    else if (intBurger != -1) { 
                        intCountItems = intCountItems + intBurger;
                    }

                } while (intBurger == -1);

                if (intCountItems < 1)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid order amount. Customers must order at least one item.");
                    Console.WriteLine("");
                }

            } while (intCountItems < 1);

            if (strCustomerCodeInput == "CATERING")
            {
                do
                {
                    intBurgerNum=Convert.ToInt32(strSand);
                    intFriesNum = Convert.ToInt32(strFries);
                    Console.WriteLine("Please enter the Name :");
                    strNameInput = Console.ReadLine();
                    Console.WriteLine("Please enter the delivery fee:");
                    //input
                    strDeliveryFee = Console.ReadLine();
                    CaterObj.CheckoutCatering(intFriesNum, intBurgerNum, strDeliveryFee, strNameInput);
                    break;              

                } while (CaterObj.CheckoutCatering(intFriesNum, intBurgerNum, strDeliveryFee, strNameInput) == 0.1);
                Console.WriteLine(CaterObj.ToString());
                

            }
            else if (strCustomerCodeInput == "CONSUMER")
            {
                intBurger = Convert.ToInt32(strSand);
                intFries = Convert.ToInt32(strFries);
                Console.WriteLine("Please enter the Name :");
                strNameInput = Console.ReadLine();
                //input
                strDeliveryFee = Console.ReadLine();
                obj.CheckoutConsumer(intFries, intBurger,strNameInput);
                Console.WriteLine(obj.ToString());
            }
            

            //code to keep code running until we press a key
            Console.WriteLine("");
            Console.WriteLine("Please hit any key to end the order.");
            Console.ReadLine();

                //Console.WriteLine(obj.ToString());
            }
        }


    }
