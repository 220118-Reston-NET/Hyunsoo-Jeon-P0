﻿using Models;

namespace DL
{
    public interface IRepository
    {
        Customer AddCustomer(Customer p_customer);
        List<Customer> GetAllCustomer();



        Product AddProduct(Product p_product);
        List<Product> GetAllProduct();
    }
}