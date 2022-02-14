using BL;
using Models;

namespace StoreUI
{
    public class ViewOrderHistoryMenu : IMenu
    {
        private IOrderBL _orderBL;
        private List<Order> _listOfOrder;
        public ViewOrderHistoryMenu(IOrderBL p_orderBL)
        {
            _orderBL = p_orderBL;
            _listOfOrder = _orderBL.GetAllOrdersByID(PlaceOrderCustomerMenu._customerID);
        }

        public void All_Order_Display()
        {

            foreach (var item in _listOfOrder)
            {
                Console.WriteLine("********************");
                Console.WriteLine(item);
            }
        }
        public void Display()
        {
            //StoreFront_ProductDisplay();
            All_Order_Display();
            Console.WriteLine("********************");
            //Console.WriteLine("[1] Press Store ID to contine order");
            Console.WriteLine("[0] Go back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "PlaceOrderStore";
                // case "1":
                //     Console.WriteLine("Enter Store ID");
                //     _storeID = Convert.ToInt32(Console.ReadLine());

                //     while (_listOfStoreFront.All(p => p.StoreID != _storeID))
                //     {
                //         Console.WriteLine("You Id is not vaildate! Try again!");
                //         _storeID = Convert.ToInt32(Console.ReadLine());

                //     }


                //     return "PlaceOrderCustomer";

                default:
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }
}