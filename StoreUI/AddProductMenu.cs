using Models;

namespace StoreUI
{
    public class AddProductMenu : IMenu 
    {
        private static Product _newProduct = new Product();
        public void Display()
        {
            Console.WriteLine("Enter the product information");
            Console.WriteLine("[5] Name -" + _newProduct.ProductName);
            Console.WriteLine("[4] Price -" + _newProduct.Price);
            Console.WriteLine("[3] Quantity -" + _newProduct.Quantity);
            Console.WriteLine("[2] Location -" + _newProduct.Location);
            Console.WriteLine("[1] Add product ");
            Console.WriteLine("[0] Exit");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput)
            {
                case "0":
                    return "MainMenu";
                case "1":
                    return "MainMenu";
                case "2":
                    Console.WriteLine("Please enter the location");
                    _newProduct.Location = Console.ReadLine();
                    return "AddProduct";
                case "3":
                    Console.WriteLine("Please enter the number of stock");
                    _newProduct.Quantity = Convert.ToInt32(Console.ReadLine());
                    return "AddProduct";
                case "4":
                    Console.WriteLine("Please enter the weight of the product");
                    _newProduct.Price = Convert.ToInt32(Console.ReadLine());
                    return "AddProduct";
                case "5":
                    Console.WriteLine("Please enter the name");
                    _newProduct.ProductName = Console.ReadLine();
                    return "AddProduct";
                default:
                    Console.WriteLine("Plese input a valid response");
                    Console.WriteLine("Plese press enter to continue");
                    Console.ReadLine();
                    return "AddProduct";
            }
        }
    }
}