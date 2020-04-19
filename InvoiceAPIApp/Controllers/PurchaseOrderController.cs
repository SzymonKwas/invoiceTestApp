using InvoiceAPIApp.Models;
using InvoiceAPIApp.Services.PurchaseOrderService;
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

        private readonly PurchaseOrderService _purchaseOrderService;

        public PurchaseOrderController(PurchaseOrderService purchaseOrderService)
        {
            _purchaseOrderService = purchaseOrderService;
        }


        public List<PurchaseOrder> Get()
        {
            return _purchaseOrderService.getAllPurchaseOrders();
        }

        
        public PurchaseOrder Get(int id)
        {
            return _purchaseOrderService.getPurchaseOrderById(id);
        }

       
        public PurchaseOrder Post([FromBody]PurchaseOrder value)
        {
            return _purchaseOrderService.createPurchaseOrder(value);
        }


    }
}
