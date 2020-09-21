using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Core.Interfaces.Services
{
    public interface IOrderTableService
    {
        IEnumerable<OrderTable> GetOrdersAsync(bool isCompleted);
        Task UpdateOrderAsync(OrderTable orderTable);
    }
}
