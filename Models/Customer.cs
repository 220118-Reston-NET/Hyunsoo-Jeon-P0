namespace Models{
    public class Customer{
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string ContactNo { get; set; }

        public Customer(){
            Name="Hyunsoo";
            Address="1234 Main St, San Jose, CA 11111";
            Email = "hyunsoo@email.com";
            ContactNo = "123-456-7890";
        }
    }
}