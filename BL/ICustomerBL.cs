using Models;

namespace BL
{   
    public interface ICustomerBL
    {
        Customer AddCustomer(Customer p_customer);

        List<Customer> SearchCustomer(string p_name);
    }
}