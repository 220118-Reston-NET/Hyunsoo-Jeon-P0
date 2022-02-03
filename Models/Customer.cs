namespace Models{
    public class Customer{
        
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }
        private List<Order> _order ;
        public List<Order> Order
        {
            get { return _order; }
            set { _order = value; }
        }
        

        public Customer(){
            Name="Hyunsoo";
            Address="1234 Main St, San Jose, CA 11111";
            Email = "hyunsoo@email.com";
            ContactNo = "123-456-7891";
            _order = new List<Order>()
            {
                new Order()
            };
        }

        public override string ToString()
        {
            return $"ID: {CustomerID} \nName: {Name}\n Address: {Address}\n Email: {Email}\n Contact number: {ContactNo}";
        }
    }

}