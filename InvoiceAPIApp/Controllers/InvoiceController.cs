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
            return null;
        }

        
        public void Post([FromBody]Invoice value)
        {
        }

    }
}
