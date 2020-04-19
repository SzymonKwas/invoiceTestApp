using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InvoiceAPIApp.Models;
using InvoiceAPIApp.Repository.Invoice;

namespace InvoiceAPIApp.Services.PurchaseOrderService
{
    public class PurchaseOrderServiceImpl : PurchaseOrderService
    {

        private readonly PurchaseOrderRepository _purchaseOrderRepository;

        public PurchaseOrderServiceImpl(PurchaseOrderRepository purchaseOrderRepository)
        {
            this._purchaseOrderRepository = purchaseOrderRepository;
        }

        public PurchaseOrder createPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            return _purchaseOrderRepository.AddPurchaseOrder(purchaseOrder);
        }

        public List<PurchaseOrder> getAllPurchaseOrders()
        {
            return _purchaseOrderRepository.GetAllPurchaseOrders();
        }

        public PurchaseOrder getPurchaseOrderById(int Id)
        {
            return _purchaseOrderRepository.GetPurchaseOrderById(Id);
        }
    }
}