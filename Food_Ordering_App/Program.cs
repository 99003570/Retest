using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Food_Ordering_App
{
    public enum CustomerType 
    {
        VISITOR, 
        PICKUP 
    };
    class Program
    {
        public static void Main(string[] args)
        {

            string strCustomerCodeInput;
            string strFries;
            int intFries;
            string strBurger;
            int intBurger;
            int intCountItems;
            string strDeliveryFee;
            int intFriesNum;
            string strNameInput;
            //Console.WriteLine("Enter number of burger");
            int intBurgerNum;
            PickUpOrder CaterObj = new PickUpOrder();
            VisitorOrder obj = new VisitorOrder();
            Validation VObj = new Validation();

            //declaring Boolean variable for customer type and positive number validation
            Boolean bolCustomerType;

            try { 
            //Get customer type from the user with a while post validation loop
            do
            {
                //Ask for the Customer Type
                Console.WriteLine("Which type of order would you like to process <VISITOR or PICKUP>?");
                strCustomerCodeInput = Console.ReadLine().ToUpper();

                //calling validation method to validate the users input on type of customer
                bolCustomerType = VObj.CheckCustomerType(strCustomerCodeInput);

                //prints error message if the customer enters incorrect value for type of customer
                if (bolCustomerType == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Invalid customer type. Please enter either 'VISITOR' or 'PICKUP'. ");
                    Console.WriteLine("");
                }
            } while (bolCustomerType == false);

            
            
                do
                {
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
                            Console.WriteLine("Invalid Fries Order Amount..");
                            Console.WriteLine("");
                        }

                        //keep order count to make sure they order at least one item
                        else if (intFries != -1)
                        {
                            intCountItems = intCountItems + intFries;
                        }
                    } while (intFries == -1);

                    //Burger order loop
                    do
                    {
                        //asks user for input
                        Console.WriteLine("Number of Burgers");
                        strBurger = Console.ReadLine();

                        //call check positive to make sure order amount is a correct format
                        intBurger = Validation.CheckItem(strBurger);

                        //Burger error message
                        if (intBurger == -1)
                        {
                            Console.WriteLine("Invalid Burger Order Amount");
                        }
                        else if (intBurger != -1)
                        {
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

                if (strCustomerCodeInput == "PICKUP")
                {
                    do
                    {
                        intBurgerNum = Convert.ToInt32(strBurger);
                        intFriesNum = Convert.ToInt32(strFries);
                        Console.WriteLine("Please enter the Name :");
                        strNameInput = Console.ReadLine();
                        Console.WriteLine("Please enter the delivery fee:");
                        //input
                        strDeliveryFee = Console.ReadLine();
                        CaterObj.CheckoutPickUp(intFriesNum, intBurgerNum, strDeliveryFee, strNameInput);
                        break;

                    } while (CaterObj.CheckoutPickUp(intFriesNum, intBurgerNum, strDeliveryFee, strNameInput) == 0.1);
                    Console.WriteLine(CaterObj.ToString());


                }
                else if (strCustomerCodeInput == "VISITOR")
                {
                    intBurger = Convert.ToInt32(strBurger);
                    intFries = Convert.ToInt32(strFries);
                    Console.WriteLine("Please enter the Name :");
                    strNameInput = Console.ReadLine();
                    obj.CheckoutVisitor(intFries, intBurger, strNameInput);
                    Console.WriteLine(obj.ToString());
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);
            }
            //code to wait
            Console.WriteLine("");
            Console.WriteLine("Please Enter to exit.");
            Console.ReadLine();
           }
        }
    }
