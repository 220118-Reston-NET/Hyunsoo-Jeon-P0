﻿using StoreUI;

bool repeat = true;
IMenu menu = new MainMenu();

while(repeat){
    Console.Clear();
    menu.Display();
    string ans = menu.UserChoice();

    switch(ans){
        case "AddProduct":
            menu = new AddProductMenu();
            break;
        case "AddCustomer":
            menu = new AddCustomerMenu();
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