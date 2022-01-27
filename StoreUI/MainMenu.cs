namespace StoreUI{
    public class MainMenu : IMenu{
        public void Display(){
            Console.WriteLine("Welcome to Store!");
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("[4] Search Product");
            Console.WriteLine("[3] Search Customer");
            Console.WriteLine("[2] Add Customer");
            Console.WriteLine("[1] Add product ");
            Console.WriteLine("[0] Exit");
        }

        public string UserChoice(){
            string userInput = Console.ReadLine();

            switch(userInput){
                case "0":
                    return "Exit";
                case "1":
                    return "AddProduct";
                case "2":
                    return "AddCustomer";
                case "3":
                    return "SearchCustomer";
                case "4":
                    return "SearchProduct";
                default:
                    Console.WriteLine("Please input a vaild response");
                    Console.WriteLine("Please press Enter to continue");
                    Console.ReadLine();
                    return "MainMenu";
            }
        }
    }
}