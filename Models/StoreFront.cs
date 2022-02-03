namespace Models
{
    public class StoreFront
    {
        public int StoreId { get; set; }
        public string StoreName { get; set; }
        public string StoreAddress { get; set; }
        private List<Product> _listOfProdct;
        public List<Product> ListOfProduct
        {
            get { return _listOfProdct; }
            set { _listOfProdct = value; }
        }
        
        private List<Order> _listOfOrder;
        public List<Order> ListOfOrder
        {
            get { return _listOfOrder; }
            set { _listOfOrder = value; }
        }

        public StoreFront(){
            StoreName="All parts 1";
            StoreAddress="7777 Main St, San Jose, CA 77777";
            _listOfProdct = new List<Product>()
            {
                new Product()
            };
            _listOfOrder = new List<Order>()
            {
                new Order()
            };
        }

        public override string ToString()
        {
            return $"ID: {StoreId} \nName: {StoreName}\n Address: {StoreAddress}";
        }

    }
}