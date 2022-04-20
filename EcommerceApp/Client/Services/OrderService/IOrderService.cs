namespace EcommerceApp.Client.Services.OrderService
{
    public interface IOrderService
    {
        //Task PlaceOrder();
        Task<string> PlaceOrder();
        Task<List<OrderOverviewResponse>> GetOrders();
        Task<OrderDetailsResponse> GetOrderDetails(int orderId);
    }
}
