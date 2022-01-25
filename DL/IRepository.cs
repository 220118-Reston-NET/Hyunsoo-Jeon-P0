using Models;

namespace DL
{
    public interface IRepository
    {
        Customer AddCustomer(Customer p_customer);

        Product AddProduct(Product p_product);
    }
}