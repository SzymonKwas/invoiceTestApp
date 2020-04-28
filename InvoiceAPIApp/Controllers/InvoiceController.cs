using InvoiceAPIApp.Models;
using InvoiceAPIApp.Services.InvoiceService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InvoiceAPIApp.Controllers
{
    public class InvoiceController : ApiController
    {

        private readonly InvoiceService _invoiceService;

        public InvoiceController(InvoiceService invoiceService)
        {
            _invoiceService = invoiceService;
        }

        public List<Invoice> Get()
        {
            return new List<Invoice>();
        }

        
        public Invoice Get(int id)
        {
            return new Invoice(1, "pole1", "pole2","pole3");
        }

        
        public HttpResponseMessage Post([FromBody]Invoice value)
        {   
            System.Diagnostics.Debug.WriteLine(value);
            
            var response = Request.CreateResponse(HttpStatusCode.OK, value);
            response.Headers.Add("Jakistamheader2", "Jakaswartoscstring2");
            return response;
        }

    }
}
