using System.Web.Http;
using Unity;

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

            // Tutaj dodaje sie Serwisy/Repozytoria do wstrzykniecia
            var container = DependencyInjectionContainerHandler.setupContainer(new UnityContainer());

            config.DependencyResolver = new UnityResolver(container);
        }

    }
}
