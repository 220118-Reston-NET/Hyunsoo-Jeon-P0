namespace Models{
    public class Customer{
        
        public int CustomerID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }

        public Customer(){
            Name="Hyunsoo";
            Address="1234 Main St, San Jose, CA 11111";
            Email = "hyunsoo@email.com";
            ContactNo = "123-456-7891";
        }

        public override string ToString()
        {
            return $"Name: {Name}\n Address: {Address}\n Email: {Email}\n Contact number: {ContactNo}";
        }
    }

}