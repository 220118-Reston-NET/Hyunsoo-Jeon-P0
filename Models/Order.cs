namespace Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public int TotalPrice { get; set; }
        private List<StoreFront> _listOfStore;
        public List<StoreFront> ListOfStore
        {
            get { return _listOfStore; }
            set { _listOfStore = value; }
        }

        private List<LineItems> _lineItems;
        public List<LineItems> LineItems
        {
            get { return _lineItems; }
            set { _lineItems = value; }
        }
        
        
        public Order()
        {
            TotalPrice = 15;
            // _listOfStore = new List<StoreFront>
            // {
            //     new StoreFront()
            // };
        }
    }
}