using InvoiceAPIApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPIApp.Services.PurchaseOrderService
{
    public interface PurchaseOrderService
    {
        List<PurchaseOrder> getAllPurchaseOrders();
        PurchaseOrder createPurchaseOrder(PurchaseOrder purchaseOrder);

        PurchaseOrder getPurchaseOrderById(int Id);
    }
}
