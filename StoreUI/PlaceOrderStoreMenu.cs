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
        }

        public static StoreFront _storeNameSelect = new StoreFront();
        private List<StoreFront> _listOfStoreFront;
        private List<Product> _listOfProduct;

        public void StoreFront_ProductDisplay(){
            _listOfStoreFront = _storeFrontBL.GetAllStoreFront();
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
            Console.WriteLine("Press Store Name to contine order");
            Console.WriteLine("[0] Go back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "0":
                    return "CustomerMenu";
                default:
                    foreach(var item in _listOfStoreFront)
                    {
                        if(userInput == item.StoreName)
                        {
                            _storeNameSelect = item;
                            return "PlaceOrderDetail";
                        }
                    }
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "PlaceOrderStore";          
            }
        }
    }
}