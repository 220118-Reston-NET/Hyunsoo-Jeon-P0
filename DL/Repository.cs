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

            List<Customer> listOfCustomer = GetAllCustomer();
            listOfCustomer.Add(p_customer);

            _jsonString = JsonSerializer.Serialize(listOfCustomer, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString);

            return p_customer;
        }

        public List<Customer> GetAllCustomer()
        {
            _jsonString = File.ReadAllText(_filepath + "Customer.json");

            return JsonSerializer.Deserialize<List<Customer>>(_jsonString);
            
        }

        public Product AddProduct(Product p_product)
        {
            string path = _filepath + "Product.json";
            
            List<Product> listOfProduct = GetAllProduct();
            listOfProduct.Add(p_product);

            _jsonString1 = JsonSerializer.Serialize(listOfProduct, new JsonSerializerOptions {WriteIndented = true});

            File.WriteAllText(path, _jsonString1);

            return p_product;
        }

        public List<Product> GetAllProduct()
        {
            _jsonString = File.ReadAllText(_filepath + "Customer.json");

            return JsonSerializer.Deserialize<List<Product>>(_jsonString);
            
        }
    }
}