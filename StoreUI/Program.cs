using StoreUI;
using BL;
using DL;

bool repeat = true;
IMenu menu = new MainMenu();

while(repeat){
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch(ans){
        case "SearchProduct":
            menu = new SearchProductMenu(new ProductBL(new Repository()));
            break;
        case "SearchCustomer":
            menu = new SearchCustomerMenu(new CustomerBL(new Repository()));
            break;
        case "AddProduct":
            menu = new AddProductMenu(new ProductBL(new Repository()));
            break;
        case "AddCustomer":
            menu = new AddCustomerMenu(new CustomerBL(new Repository()));
            break;
        case "MainMenu":
            menu = new MainMenu();
            break;
        case "Exit":
            repeat = false;
            break;
        default:
            Console.WriteLine("Page does not exist");
            break;
    }
}