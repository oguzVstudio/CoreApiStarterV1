using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sTest.Api.Contracts_Routes_.v1;
using sTest.MetaData.Core.Interfaces.Services;

namespace sTest.Api.Controllers.ApplicationControllers
{
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
    [Produces(contentType: "application/json")]
    public class SellerController : Controller
    {
        private readonly ISellerService _sellerService;
        private readonly IOrderTableService _orderTableService;
        private readonly ISalesTableService _salesTableService;
        private readonly ISellerTargetService _sellerTargetService;

        public SellerController(ISellerService sellerService, IOrderTableService orderTableService, ISalesTableService salesTableService, ISellerTargetService sellerTargetService)
        {
            _sellerService = sellerService;
            _orderTableService = orderTableService;
            _salesTableService = salesTableService;
            _sellerTargetService = sellerTargetService;
        }


        /// <summary>
        /// Seller Sales
        /// </summary>
        /// <response code="200">result ok</response>
        [HttpGet(ApiRoutes.Seller.GetSellerSales)]
        public async Task<IActionResult> GetSellerSales()
        {
            var sellerSales = await _salesTableService.GetSalesAsync();
            var sellerTarget =  _sellerTargetService.GetSellersTarget(9, 2020);

            if (sellerSales == null)
                return NotFound();

            var sales = sellerSales.GroupBy(u => u.SellerId).Join(sellerTarget, (u => u.Key), (k => k.SellerId), (u, k) => new { Sales = u, Target = k }).Select(u => new
            {
                SellerId = u.Sales.Key,
                SellerName = u.Sales.Max(k => k.Seller.SellerName),
                Amount = u.Sales.Sum(k => k.Order.Amount),
                Target = u.Target.Target
            }).ToList();
            

            return Ok(sales);
        }
    }
}
