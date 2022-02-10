using BL;
using Models;

namespace StoreUI
{
    public class PlaceOrderDetailMenu : IMenu
    {
        private IOrderBL _orderBL;
        private IInventoryBL _inventoryBL;
        private IStoreFrontBL _storeFrontBL;
        public PlaceOrderDetailMenu(IOrderBL p_orderBL, IInventoryBL p_inventoryBL, IStoreFrontBL p_storeFrontBL)
        {
            _orderBL = p_orderBL;
            _inventoryBL = p_inventoryBL;
            _storeFrontBL = p_storeFrontBL;
        }

        private List<Inventory> listOfInventory = new List<Inventory>();
        private List<Product> listOfProduct = new List<Product>();
        private List<LineItems> newOrder = new List<LineItems>();
        private static List<Customer> newCustomer = new List<Customer>();
        private List<StoreFront> _listOfStoreFront = new List<StoreFront>();
        private OrderBL orderBL;
        public void StoreListDisplay(){
            Console.WriteLine("Check Store list");
            _listOfStoreFront = _storeFrontBL.GetAllStoreFront();
            foreach(var item in _listOfStoreFront)
            {
                Console.WriteLine("********************");
                Console.WriteLine(item);
            }
        }

        
        public void Display()
        {
            StoreListDisplay();
            Console.WriteLine("********************");
            Console.WriteLine("Let's start order!");
            Console.WriteLine("[1] View Store Inventory / Check Store Id");
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
                    Console.WriteLine("Please enter a Store ID");
                    try
                    {
                        int storeID = Convert.ToInt32(Console.ReadLine());
                        List<Product> listOfStoreProduct = _inventoryBL.GetAllInventoryDetailInStoreByID(storeID);
                        foreach(var item in listOfStoreProduct)
                        {
                            Console.WriteLine("====================");
                            Console.WriteLine(item);
                        }
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();

                        return "PlaceOrderDetail";
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please input a valid response");
                        Console.WriteLine("Please press Enter to continue");
                        Console.ReadLine();
                        return "PlaceOrderDetail";
                    }
                    return "PlaceOrderDetail";
                default:
                    
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "PlaceOrderDetail";          
                
            }
        }
    }
}