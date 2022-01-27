global using Serilog;
using StoreUI;
using BL;
using DL;

Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt").CreateLogger();

bool repeat = true;
IMenu menu = new MainMenu();

while(repeat){
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch(ans){
        case "SearchProduct":
            Log.Information("Displaying Search product Menu to user");
            menu = new SearchProductMenu(new ProductBL(new Repository()));
            break;
        case "SearchCustomer":
            Log.Information("Displaying Search Customer Menu to user");
            menu = new SearchCustomerMenu(new CustomerBL(new Repository()));
            break;
        case "AddProduct":
            Log.Information("Displaying Adding product Menu to user");
            menu = new AddProductMenu(new ProductBL(new Repository()));
            break;
        case "AddCustomer":
            Log.Information("Displaying Adding customer Menu to user");
            menu = new AddCustomerMenu(new CustomerBL(new Repository()));
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            Log.Information("Exiting application");
            Log.CloseAndFlush(); 
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist");
            Console.WriteLine("Please press Enter to continue");
            Console.ReadLine();
            break;
    }
}