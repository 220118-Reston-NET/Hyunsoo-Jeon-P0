using BL;
using Models;

namespace StoreUI
{  
    public class SearchStoreFrontMenu: IMenu
    {
        private IStoreFrontBL _storeFrontBL;
        public SearchStoreFrontMenu(IStoreFrontBL p__storeFrontBL)
        {
            _storeFrontBL = p__storeFrontBL;
        }

        public void Display()
       {
            Console.WriteLine("Please select an option to filter the Store database");
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

                    Console.WriteLine("Please enter a product name");
                    string storetName = Console.ReadLine();

                    List<StoreFront> listOfStoreFront = _storeFrontBL.SearchStoreFront(storetName);
                    foreach(var item in listOfStoreFront)
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
                    return "SearchStoreFront";              
           }
       }

    }
}