using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hangfire.Kurutek;
using Kurutek.API.Controllers;

namespace Hangfire.Kurutek
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHangfire(x => x.UseSqlServerStorage("server=DESKTOP-2RFMJGK\\SQLEXPRESS;database=Hangfire.Kurutek;integrated security=true;"));

            services.AddControllers();

            services.AddHangfireServer();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseHangfireDashboard();
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            //Trendyol entegrasyonu jobu
            RecurringJob.AddOrUpdate("Trendyol_Entegrasyon", () => TrendyolOrdersController.TrendyolOrders(), Cron.MinuteInterval(3));
        }
    }
}
