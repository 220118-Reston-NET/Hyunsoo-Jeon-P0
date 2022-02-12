using BL;
using Models;

namespace StoreUI
{
    public class PlaceOrderStoreMenu : IMenu
    {
        private IStoreFrontBL _storeFrontBL;
        public PlaceOrderStoreMenu(IStoreFrontBL p_storeFrontBL)
        {
            _storeFrontBL = p_storeFrontBL;
            _listOfStoreFront = _storeFrontBL.GetAllStoreFront();

        }

        public static StoreFront _storeNameSelect = new StoreFront();
        private List<StoreFront> _listOfStoreFront;
        private List<Product> _listOfProduct;
        public static int _storeID;

        public void StoreFront_ProductDisplay(){
            foreach(var item in _listOfStoreFront)
            {
                Console.WriteLine("********************");
                Console.WriteLine(item);
            }
        }
        public void Display()
        {
            StoreFront_ProductDisplay();

            Console.WriteLine("********************");
            Console.WriteLine("[1] Press Store ID to contine order");
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
                    Console.WriteLine("Enter Store ID");
                    _storeID = Convert.ToInt32(Console.ReadLine());
      
                        while(_listOfStoreFront.All(p => p.StoreID != _storeID))
                        {
                            Console.WriteLine("You Id is not vaildate! Try again!");
                            _storeID = Convert.ToInt32(Console.ReadLine());
                            
                        }

                    
                return "PlaceOrderCustomer";

            default:
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "PlaceOrderStore";          
            }
        }
    }
}