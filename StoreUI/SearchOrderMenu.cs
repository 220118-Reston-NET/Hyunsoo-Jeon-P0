using BL;
using Models;

namespace StoreUI
{  
    public class SearchOrderMenu: IMenu
    {
        private IOrderBL _orderBL;
        public SearchOrderMenu(IOrderBL p_orderBL)
        {
            _orderBL = p_orderBL;
        }

        public void Display()
       {
            Console.WriteLine("Please select an option to filter the order database");
            Console.WriteLine("[1] view orders");
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

                    // Console.WriteLine("Please enter a Order ID");

                    try
                    {
                        int orderID = Convert.ToInt32(Console.ReadLine());
                        List<Order> listOfOrder = _orderBL.GetAllOrder();
                        foreach(var item in listOfOrder)
                        {
                            Console.WriteLine("====================");
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();

                        return "MainMenu";
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        return "SearchOrder";
                    }
                    return "SearchOrder";
                default:
                    Console.WriteLine("Please input a valid response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "SearchOrder";              
           }
       }

    }
}