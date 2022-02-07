using Models;

namespace DL
{
    public interface IRepository
    {
        Customer AddCustomer(Customer p_customer);
        List<Customer> GetAllCustomer();

        List<Customer> GetCustomerByCustomerID(int p_customerID);

        Product AddProduct(Product p_product);
        List<Product> GetAllProduct();

        StoreFront AddStoreFront(StoreFront p_storeFront);
        List<StoreFront> GetAllStoreFront();
        List<Inventory> GetAllInventory();

        List<Product> GetAllInventoryDetailInStoreByID(int p_storeId);

        Inventory AddInventory(Inventory p_inventory);
    }
}