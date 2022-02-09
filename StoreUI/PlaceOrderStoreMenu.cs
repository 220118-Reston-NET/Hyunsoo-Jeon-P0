using BL;
using Models;

namespace StoreUI
{
    public class PlaceOrderStoreMenu : IMenu
    {
        private IStoreFrontBL _storeFrontBL;
        public PlaceOrderStoreMenu(IStoreFrontBL p__storeFrontBL)
        {
            _storeFrontBL = p__storeFrontBL;
        }

        public void Display()
        {
            Console.WriteLine("Check all stores");
            Console.WriteLine("[1] view stores");
            Console.WriteLine("[0] Go back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "0":
                    return "CustomerMenu";
                case "1":
                    try
                    {
                        List<StoreFront> listOfStoreFront = _storeFrontBL.GetAllStoreFront();
                    foreach(var item in listOfStoreFront)
                    {
                        Console.WriteLine("********************");
                        Console.WriteLine(item);
                    }
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();

                    return "CustomerMenu";
                    }
                    catch (System.Exception)
                    {
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                    }
                    return "CustomerMenu";
                default:
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "CustomerMenu";          
                
            }
        }
    }
}