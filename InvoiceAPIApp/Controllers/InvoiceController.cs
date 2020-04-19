using InvoiceAPIApp.Models;
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
        // GET: api/Invoice
        public List<Invoice> Get()
        {
            return new List<Invoice>();
        }

        // GET: api/Invoice/5
        public Invoice Get(int id)
        {
            return null;
        }

        // POST: api/Invoice
        public void Post([FromBody]Invoice value)
        {
        }

    }
}
