namespace Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        private int _price;
        public int Price
        {
            get { return _price; }
            set { 
                    if(value >=0)
                    {
                        _price = value; 
                    }
                    else 
                    {
                        throw new Exception("Price should not be negative value");
                    }
                }    
        }
        
        //private int _quantity;
        //public int Quantity
        //{
        //    get { return _quantity; }
        //    set { 
        //        if(value >= 0) {
        //            _quantity = value;
        //        } else {
        //            throw new Exception("Stock ran out!");
        //        }
        //    }
        //}

        public Product(){
            ProductName = "Coolant";
            //Quantity = 10;
            Price = 15;
        }
        public override string ToString()
        {
            return $"ID: {ProductID} \nProduct Name: {ProductName}\n Price: {Price}";
        }
    }
}    
