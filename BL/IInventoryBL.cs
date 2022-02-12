using Models;

namespace BL
{   
    public interface IInventoryBL
    {
        List<Inventory> GetAllInventory();
        Inventory AddInventory(Inventory p_inventory);

        List<Inventory> GetAllInventoryDetailInStoreByID(int p_storeId);

        List<Product> GetAllproductDetailByStoreID(int p_storeId);
    }
}