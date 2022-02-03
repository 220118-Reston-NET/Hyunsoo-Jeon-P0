namespace Models
{
    public class LineItems
    {
        public string ProductID { get; set; }
        public string OrderId { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }           
        public int Qty { get; set; }

        public LineItems()
        {
            ProductName = "Coolant";
            Price = 10;
            Qty = 20;
        }

        public override string ToString()
        {
            return $"Product name : {ProductName}\n Price : {Price} \n Quantity: {Qty}";
        }
    }
}