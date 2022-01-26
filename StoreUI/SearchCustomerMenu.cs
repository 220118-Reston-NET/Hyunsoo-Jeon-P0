using BL;
using Models;

namespace StoreUI
{  
   public class SearchCustomerMenu: IMenu
   {
       private ICustomerBL _customerBL;
       public SearchCustomerMenu(ICustomerBL p_customerBL)
       {
           _customerBL = p_customerBL;
       }

       public void Display()
       {
            Console.WriteLine("Please select an option to filter the customer database");
            Console.WriteLine("[1] By Name");
            Console.WriteLine("[0] Go back");
       }

       public string UserChoice()
       {
           string userInput = Console.ReadLine();

           switch(userInput)
           {
                case "0":
                    return "MainMenu";
                case "1":

                    Console.WriteLine("Please enter a name");
                    string name = Console.ReadLine();

                    List<Customer> listOfCustomer = _customerBL.SearchCustomer(name);
                    foreach(var item in listOfCustomer)
                    {
                        Console.WriteLine("********************");
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();

                    return "MainMenu";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "SearchCustomer";              
           }
       }
   } 
}