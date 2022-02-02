global using Serilog;
using StoreUI;
using BL;
using DL;
using Microsoft.Extensions.Configuration;

Log.Logger = new LoggerConfiguration()
    .WriteTo.File("./logs/user.txt").CreateLogger();

var configuration = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json")
        .Build();

string _connectionString = configuration.GetConnectionString("Reference2DB");


bool repeat = true;
IMenu menu = new MainMenu();

while(repeat){
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch(ans){
        case "SearchProduct":
            Log.Information("Displaying Search product Menu to user");
            menu = new SearchProductMenu(new ProductBL(new SQLRepository(_connectionString)));
            break;
        case "SearchCustomer":
            Log.Information("Displaying Search Customer Menu to user");
            menu = new SearchCustomerMenu(new CustomerBL(new SQLRepository(_connectionString)));
            break;
        case "AddProduct":
            Log.Information("Displaying Adding product Menu to user");
            menu = new AddProductMenu(new ProductBL(new SQLRepository(_connectionString)));
            break;
        case "AddCustomer":
            Log.Information("Displaying Adding customer Menu to user");
            menu = new AddCustomerMenu(new CustomerBL(new SQLRepository(_connectionString)));
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