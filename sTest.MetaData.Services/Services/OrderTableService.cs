using sTest.MetaData.Core.Interfaces.Services;
using sTest.MetaData.Core.Interfaces.UnitOfWork;
using sTest.MetaData.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace sTest.MetaData.Services.Services
{
    public class OrderTableService : IOrderTableService
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderTableService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }
        public IEnumerable<OrderTable> GetOrdersAsync(bool isCompleted)
        {
            return _unitOfWork.OrderTableRepository.Find(u => u.IsCompleted == isCompleted);
        }

        public async Task UpdateOrderAsync(OrderTable orderTable)
        {
            _unitOfWork
                .OrderTableRepository
                .Update(orderTable);

            await _unitOfWork.CommitAsync();
        }
    }
}
