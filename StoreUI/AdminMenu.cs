namespace StoreUI
{
    public class AdminMenu : IMenu
    {
        public void Display()
        {
            Console.WriteLine("Good Day! ");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[6] Search Store");
            Console.WriteLine("[5] Search Product");
            Console.WriteLine("[4] Search Customer");            
            Console.WriteLine("[3] Add Store Front");
            Console.WriteLine("[2] Add Customer");
            Console.WriteLine("[1] Add product ");
            Console.WriteLine("[0] Go back");
        }

        public string UserChoice()
        {
            string userInput = Console.ReadLine();

            switch(userInput){
                case "0":
                    return "Exit";
                case "1":
                    return "AddProduct";
                case "2":
                    return "AddCustomer";
                case "3":
                    return "AddStoreFront";
                case "4":
                    return "SearchCustomer";
                case "5":
                    return "SearchProduct";
                case "6":
                    return "SearchStoreFront";
                default:
                    Console.WriteLine("Please input a vaild response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }
}