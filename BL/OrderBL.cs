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


    }
}