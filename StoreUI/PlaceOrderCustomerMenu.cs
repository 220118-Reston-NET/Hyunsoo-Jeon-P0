using BL;
using Models;

namespace StoreUI
{
    public class PlaceOrderCustomerMenu : IMenu
    {
        private ICustomerBL _customerBL;
        public PlaceOrderCustomerMenu(ICustomerBL p_customerBL)
        {
            _customerBL = p_customerBL;
            _listOfCustomer = _customerBL.GetAllCustomer();

        }

        // public static Customer _storeNameSelect = new StoreFront();
        private List<Customer> _listOfCustomer;

       // private List<Product> _listOfProduct;
        public static int _customerID;

        public void Customer_Display()
        {
            foreach (var item in _listOfCustomer)
            {
                Console.WriteLine("********************");
                Console.WriteLine(item);
            }
        }
        public void Display()
        {
            Customer_Display();

            Console.WriteLine("********************");
            Console.WriteLine("[1] Press Customer ID to contine order");
            Console.WriteLine("[0] Go back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "0":
                    return "PlaceOrderStore";
                case "1":
                    Console.WriteLine("Enter customer ID");
                    _customerID = Convert.ToInt32(Console.ReadLine());
            

                        while (_listOfCustomer.All(c => c.CustomerID != _customerID))
                        {
                            Console.WriteLine("You Id is not vaildate! Try again!");
                            _customerID = Convert.ToInt32(Console.ReadLine());

                        }
                    return "PlaceOrderDetail";

                default:
                   
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "PlaceOrderCustomer";
            }
        }
    }
}