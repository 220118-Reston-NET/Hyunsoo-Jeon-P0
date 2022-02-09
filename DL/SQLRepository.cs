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

        public Inventory AddInventory(Inventory p_inventory)
        {
            string sqlQuery = @"insert into Inventory
                            values(@qty, @storeId, @productId)";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@qty", p_inventory.Qty);
                command.Parameters.AddWithValue("@storeId", p_inventory.StoreID);
                command.Parameters.AddWithValue("@productId", p_inventory.ProductID);


                command.ExecuteNonQuery();
            }
            return p_inventory;
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

        public List<Inventory> GetAllInventory()
        {
            List<Inventory> _listOfinventory = new List<Inventory>();
            
            string sqlQuery = $"select * from Inventory";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();
                
                while(reader.Read())
                {
                    _listOfinventory.Add(new Inventory()
                    {
                        InventoryID = reader.GetInt32(0),
                        Qty = reader.GetInt32(1),
                        StoreID = reader.GetInt32(2),
                        ProductID = reader.GetInt32(3)
                    });
                }

                }
            
            return _listOfinventory;
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
                        StoreID = reader.GetInt32(0),
                        StoreName = reader.GetString(1),
                        StoreAddress = reader.GetString(2),
                    });
                }
            }
            return listOfStoreFront;
        }

        public List<Customer> GetCustomerByCustomerID(int p_customerID)
        {
            List<Customer> listOfCustomer = new List<Customer>();
            string sqlQuery = @"select * from Customer c
                                where c.customerID = @customerID";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@customerID", p_customerID);

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

        public List<Product> GetAllInventoryDetailInStoreByID(int p_storeId)
        {
                     
            List<Product> _listOfInventory = new List<Product>();
            string sqlQuery = @"select p.productId, p.productName, p.productPrice from Product p, Inventory i
                                where p.productId = i.productId and i.storeId = @storeId";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);
                command.Parameters.AddWithValue("@storeId", p_storeId);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                     _listOfInventory.Add(new Product(){
                        ProductID = reader.GetInt32(0),
                        ProductName = reader.GetString(1),
                        Price = reader.GetInt32(2)
                    });
                }
            }
            return _listOfInventory; 
        }

         public List<Order> GetAllOrder()
        {
            List<Order> _listOfOrder = new List<Order>();

            string sqlQuery = @"select * from Orders";

            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQuery, con);

                SqlDataReader reader = command.ExecuteReader();

                while(reader.Read())
                {
                    _listOfOrder.Add(new Order(){
                        OrderID = reader.GetInt32(0),
                        TotalPrice = reader.GetInt32(1),
                        StoreID = reader.GetInt32(2),
                        CustomerID = reader.GetInt32(3),
                    });
                }
            }
            return _listOfOrder;
        }

        public Order PlaceOrder(int p_storeId, int p_customerID, int p_totalPrice, List<LineItems> p_lineItem)
        {
            string sqlQueryOrder = @"insert into Orders
                            values(@orderId, @orderTotalPrice, @storeId, @customerID)";

            string sqlQueryLineItem = @"insert into LineItem
                                    values(@qty, @orderId, @productId)";

            Order _newOrder = new Order();


            using(SqlConnection con = new SqlConnection(_connectionStrings))
            {
                con.Open();

                SqlCommand command = new SqlCommand(sqlQueryOrder, con);
                command.Parameters.AddWithValue("@orderId", _newOrder.OrderID);
                command.Parameters.AddWithValue("@orderTotalPrice", p_totalPrice);
                command.Parameters.AddWithValue("@storeId", p_storeId);
                command.Parameters.AddWithValue("@customerID", p_customerID);

                command.ExecuteNonQuery();

                foreach(var item in p_lineItem)
                {
                    command = new SqlCommand(sqlQueryLineItem, con);
                    command.Parameters.AddWithValue("@qty", item.Qty);
                    command.Parameters.AddWithValue("@orderId", _newOrder.OrderID);
                    command.Parameters.AddWithValue("@productId", item.ProductID);

                    command.ExecuteNonQuery();

                }
            
            }

            return _newOrder;
        }

    }
}

