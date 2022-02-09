using Models;

namespace BL
{   
    public interface IOrderBL
    {
        List<Order> GetAllOrder();

        Order PlaceOrder(int p_storeId, int p_customerID, int p_totalPrice, List<LineItems> p_lineItem);
    }
}