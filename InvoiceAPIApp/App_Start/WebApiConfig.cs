using InvoiceAPIApp.Repository.Invoice;
using InvoiceAPIApp.Services.InvoiceService;
using InvoiceAPIApp.Services.PurchaseOrderService;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace InvoiceAPIApp
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Konfiguracja i usługi składnika Web API
            // Trasy składnika Web API
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddSingleton<InvoiceRepository>();
        services.AddSingleton<InvoiceService>();

        services.AddSingleton<PurchaseOrderRepository>();
        services.AddSingleton<PurchaseOrderService>();
    }

}
