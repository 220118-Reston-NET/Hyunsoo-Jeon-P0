using DL;
using Models;

namespace BL
{
    public class InventoryBL : IInventoryBL
    {
        private IRepository _repo;

        public InventoryBL(IRepository p_repo)
        {
            _repo = p_repo;
        }

        public List<Inventory> GetAllInventory()
        {
            return _repo.GetAllInventory();
        }

        public Inventory AddInventory(Inventory p_inventory)
        {
            return _repo.AddInventory(p_inventory);
        }

        public List<Inventory> GetAllInventoryDetailInStoreByID(int p_storeId)
        {
            return GetAllInventory().Where(p => p.StoreID.Equals(p_storeId)).ToList();
        }

        public List<Product> GetAllproductDetailByStoreID(int p_storeId)
        {
           return _repo.GetAllproductDetailByStoreID(p_storeId);
        }
    }
}