using DL;
using Models;

namespace BL
{
    public class CustomerBL : ICustomerBL
    {
        private IRepository _repo;
        public CustomerBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public Customer AddCustomer(Customer p_customer)
        {   
            List<Customer> listOfCustomer = _repo.GetAllCustomer();
            if(listOfCustomer.Count < 5)
            {
                return _repo.AddCustomer(p_customer);
            }
            else
            {
                throw new Exception("You cannot have more than 5 customers!");
            }

        }
    }
}