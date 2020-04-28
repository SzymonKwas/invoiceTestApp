using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;

namespace InvoiceAPIApp.App_Start
{
    public class Interceptor : DelegatingHandler
    {
        protected async override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            var response = await base.SendAsync(request, cancellationToken);
            response.Headers.Add("Jakistam-header", "jakastam-wartosc");
            response.Headers.Add("Access-Control-Allow-Methods", "GET,POST,PATCH,DELETE,PUT,OPTIONS");
            response.Headers.Add("Access-Control-Allow-Headers", "Origin, Content-Type, X-Auth-Token, content-type");
            return response;
        }

    }
}