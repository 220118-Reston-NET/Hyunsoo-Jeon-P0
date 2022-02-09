using DL;
using Models;

namespace BL
{
    public class OrderBL : IOrderBL
    {
        private IRepository _repo;
        public OrderBL(IRepository p_repo)
        {
            _repo = p_repo;
        }


        public List<Order> GetAllOrder()
        {
            return _repo.GetAllOrder();
        }

        public Order PlaceOrder(int p_storeId, int p_customerID, int p_totalPrice, List<LineItems> p_lineItem)
        {
            return _repo.PlaceOrder(p_storeId, p_customerID, p_totalPrice, p_lineItem);
        }
    }
}