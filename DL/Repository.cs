using System.Text.Json;
using Models;

namespace DL
{
    public class Repository : IRepository
    {
        private string _filepath = "../DL/Database/";
        private string _jsonString;
        private string _jsonString1;
        public Customer AddCustomer(Customer p_customer)
        {
            string path = _filepath + "Customer.json";
            _jsonString = JsonSerializer.Serialize(p_customer, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);

            return p_customer;
        }

        public Product AddProduct(Product p_product)
        {
            string path = _filepath + "Product.json";
            _jsonString1 = JsonSerializer.Serialize(p_product, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString1);

            return p_product;
        }
    }
}