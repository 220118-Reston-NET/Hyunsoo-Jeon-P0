using System.Data.SqlClient;
using Models;

namespace DL
{
    public class SQLRepository : IRepository
    {

        private readonly string _connectionStrings;
        public SQLRepository(string p_connectionStrings)
        {
            _connectionStrings = p_connectionStrings;
        }

        public Customer AddCustomer(Customer p_customer)
        {
            string sqlQuery = @"insert into Customer
                            values(@customerName, @customerAddress, @customerEmail, @customerContactNo)";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@customerName", p_customer.Name);
                command.Parameters.AddWithValue("@customerAddress", p_customer.Address);
                command.Parameters.AddWithValue("@customerEmail", p_customer.Email);
                command.Parameters.AddWithValue("@customerContactNo", p_customer.ContactNo);

                command.ExecuteNonQuery();
            }
            return p_customer;
        }

        public Product AddProduct(Product p_product)
        {
            string sqlQuery = @"insert into Product
                            values(@productName, @productPrice)";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@productName", p_product.ProductName);
                command.Parameters.AddWithValue("@productPrice", p_product.Price);

                command.ExecuteNonQuery();
            }
            return p_product;
        }

        public StoreFront AddStoreFront(StoreFront p_storeFront)
        {
            string sqlQuery = @"insert into StoreFront
                            values(@storeName, @storeAddress)";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@storeName", p_storeFront.StoreName);
                command.Parameters.AddWithValue("@storeAddress", p_storeFront.StoreAddress);

                command.ExecuteNonQuery();
            }
            return p_storeFront;
        }

        public List<Customer> GetAllCustomer()
        {
            List<Customer> listOfCustomer = new List<Customer>();

            string sqlQuery = @"select * from Customer";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    listOfCustomer.Add(new Customer(){
                        CustomerID = reader.GetInt32(0),
                        Name = reader.GetString(1),
                        Address = reader.GetString(2),
                        Email = reader.GetString(3),
                        ContactNo = reader.GetString(4)
                    });
                }
            }
            return listOfCustomer;
        }    

        public List<Product> GetAllProduct()
        {
            List<Product> listOfProduct = new List<Product>();

            string sqlQuery = @"select * from Product";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    listOfProduct.Add(new Product(){
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Price = reader.GetInt32(2),
                    });
                }
            }
            return listOfProduct;
        }

        public List<StoreFront> GetAllStoreFront()
        {
             List<StoreFront> listOfStoreFront = new List<StoreFront>();

            string sqlQuery = @"select * from StoreFront";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    listOfStoreFront.Add(new StoreFront(){
                        StoreId = reader.GetInt32(0),
                        StoreName = reader.GetString(1),
                        StoreAddress = reader.GetString(2),
                    });
                }
            }
            return listOfStoreFront;
        }
    }
}