using Models;

namespace BL
{   
    public interface IInventoryBL
    {
        List<Inventory> GetAllInventory();
        Inventory AddInventory(Inventory p_inventory);

        List<Product> GetAllInventoryDetailInStoreByID(int p_storeId);
    }
}