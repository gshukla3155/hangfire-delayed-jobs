using System;
using System.Threading.Tasks;
using Hangfire.Common;
using Hangfire.Service.Services;
using Microsoft.Owin;
using Owin;


namespace Hangfire.Service
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseHangfireDashboard();           
            DelayedJobs();
        }       

        private void DelayedJobs()
        {           
            BackgroundJob.Schedule(() => new Feedback().Send("10 seconds"), TimeSpan.FromSeconds(10));
            BackgroundJob.Schedule(() => new Feedback().Send("20 seconds"), TimeSpan.FromSeconds(20));
            BackgroundJob.Schedule(() => new Feedback().Send("1 minute"), TimeSpan.FromMinutes(1));
            BackgroundJob.Schedule(() => new Feedback().Send("2 minutes"), TimeSpan.FromMinutes(2));
            BackgroundJob.Schedule(() => new Feedback().Send("5 minutes"), TimeSpan.FromMinutes(5));
            BackgroundJob.Schedule(() => new Feedback().Send("1 hour"), TimeSpan.FromHours(1));
        }
    }
}
