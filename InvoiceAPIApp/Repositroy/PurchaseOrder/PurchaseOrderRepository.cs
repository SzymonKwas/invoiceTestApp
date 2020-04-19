using InvoiceAPIApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvoiceAPIApp.Repository.Invoice
{
    public interface PurchaseOrderRepository
    {
        List<PurchaseOrder> GetAllPurchaseOrders();

        PurchaseOrder GetPurchaseOrderById(int Id);

        PurchaseOrder AddPurchaseOrder(PurchaseOrder purchaseOrder);

        PurchaseOrder UpdatePurchaseOrder(int id, PurchaseOrder purchaseOrder);

        void DeletePurchaseOrder(int id);
    }
}
