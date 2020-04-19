using InvoiceAPIApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPIApp.Services.PurchaseOrderService
{
    interface IPurchaseOrderService
    {
        List<PurchaseOrder> getAllPurchaseOrders();
    }
}
