using sTest.Api.Interfaces.ScheduleManagers;
using sTest.MetaData.Core.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.ScheduleManagers
{
    public class OrderSalesJobManager : IOrderSalesJobManager
    {
        private readonly IOrderTableService _orderTableService;
        private readonly ISalesTableService _salesTableService;

        public OrderSalesJobManager(IOrderTableService orderTableService, ISalesTableService salesTableService)
        {
            _orderTableService = orderTableService;
            _salesTableService = salesTableService;
        }
        public void CreateSales()
        {
            Random r = new Random();
            //random sellerId between 1-7
            int sellerId = r.Next(1, 7);
            var order = _orderTableService.GetOrdersAsync(false).FirstOrDefault();
            if(order != null)
            {
                var res = _salesTableService.AddSales(new MetaData.Core.Models.SalesTable
                {
                    OrderId = order.Id,
                    SalesDate = DateTime.Now,
                    SellerId = sellerId
                }).Result;

                order.IsCompleted = true;
                _orderTableService.UpdateOrderAsync(order);
            }
        }
    }
}
