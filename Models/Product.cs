namespace Models
{
    public class Product
    {
        public string ProductName { get; set; }
        public int Price { get; set; }
        public string Location { get; set; }

        private int _quantity;
        public int Quantity
        {
            get { return _quantity; }
            set { 
                if(value >= 0) {
                    _quantity = value;
                } else {
                    throw new Exception("Stock ran out!");
                }
            }
        }

        public Product(){
            ProductName = "Coolant";
            Quantity = 10;
            Location = "L1";
            Price = 15;
        }
        public override string ToString()
        {
            return $"Product Name: {ProductName}\n Quantity: {Quantity}\n Location: {Location}\n Price: {Price}";
        }
    }
}    
