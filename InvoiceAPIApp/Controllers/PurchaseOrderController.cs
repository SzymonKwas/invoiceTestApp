using InvoiceAPIApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace InvoiceAPIApp.Controllers
{
    public class PurchaseOrderController : ApiController
    {
        // GET: api/PurchaseOrder
        public List<PurchaseOrder> Get()
        {
            return new List<PurchaseOrder>();
        }

        // GET: api/PurchaseOrder/5
        public PurchaseOrder Get(int id)
        {
            return null;
        }

        // POST: api/PurchaseOrder
        public void Post([FromBody]PurchaseOrder value)
        {
        }


    }
}
