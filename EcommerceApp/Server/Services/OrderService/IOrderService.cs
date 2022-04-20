﻿namespace EcommerceApp.Server.Services.OrderService
{
    public interface IOrderService
    {
        //Task<ServiceResponse<bool>> PlaceOrder();
        Task<ServiceResponse<bool>> PlaceOrder(int userId);
        Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrders();
        Task<ServiceResponse<OrderDetailsResponse>> GetOrdersDetails(int orderId);
    }
}