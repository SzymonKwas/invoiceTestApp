using InvoiceAPIApp.Controllers.Formatter;
using InvoiceAPIApp.Models;
using System.Web.Http;
using System.Xml.Serialization;
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


            // Konfiguracja XML Serializer
            config.Formatters.Remove(config.Formatters.JsonFormatter); // usuniecie serializera JSON


            //// Ustawienie rozwinietego serializera XmlSerializer zamiast domyslnego DataContractSerializer
            // bez tego odczytana wartosc w requescie bedzie null
            //var xml = GlobalConfiguration.Configuration.Formatters.XmlFormatter;
            //xml.UseXmlSerializer = true;
            //xml.SetSerializer<Invoice>(new XmlSerializer(typeof(Invoice)));
            //config.Formatters.Add(xml);


            config.Formatters.Insert(0, new InvoiceXmlFormatter());

        }

    }
}
