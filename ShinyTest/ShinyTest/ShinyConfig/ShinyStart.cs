using Microsoft.Extensions.DependencyInjection;
using Shiny;
using Shiny.Jobs;
using System;

namespace ShinyTest.ShinyConfig
{
    public class ShinyStart : ShinyStartup
    {
        public override void ConfigureServices(IServiceCollection services, IPlatform platform)
        {
            var job = new JobInfo(typeof(FirstJob), "FirstJob", false)
            {
                RunOnForeground = false,
                BatteryNotLow = false,
                DeviceCharging = false,
                RequiredInternetAccess = InternetAccess.Any,
                Repeat = true,
                PeriodicTime = TimeSpan.FromMinutes(1)
            };

            services.RegisterJob(job);
            services.UseJobForegroundService(TimeSpan.FromMinutes(1));
        }
    }
}
