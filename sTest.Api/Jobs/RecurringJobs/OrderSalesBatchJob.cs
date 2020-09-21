using Hangfire;
using sTest.Api.Interfaces.Jobs.RecurringJobs;
using sTest.Api.ScheduleManagers;
using sTest.BusinessLogic.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sTest.Api.Jobs.RecurringJobs
{
    public class OrderSalesBatchJob : IOrderSalesBatchJob
    {
        private readonly HangfireSettings _hangfireSettings;
        public OrderSalesBatchJob(HangfireSettings hangfireSettings) => _hangfireSettings = hangfireSettings;

        [Obsolete]
        public void CreateOrderSales()
        {
            if (_hangfireSettings.Enabled)
            {
                System.Diagnostics.Debug.WriteLine("Recurring job will be set up.");

                string cronExpression = Cron.MinuteInterval(_hangfireSettings.Recurring.Time);

                RecurringJob.RemoveIfExists(nameof(OrderSalesJobManager));

                RecurringJob.AddOrUpdate<OrderSalesJobManager>(nameof(OrderSalesJobManager),
                    job => job.CreateSales(),
                    cronExpression);
            }
        }
    }
}
