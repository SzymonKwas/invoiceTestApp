using InvoiceAPIApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace InvoiceAPIApp.Repository.Invoice
{
    public class PurchaseOrderRepositoryImpl : PurchaseOrderRepository
    {

        // TO Oczywiscie do usniecia
        List<PurchaseOrder> udajeZeJestemBazaDanych;
        int udajeZeJestemWygenerowanymID = 0;

        public PurchaseOrderRepositoryImpl()
        {
            // TODO: PODPIAC BAZE
            // UDAJE ZE JESTEM BAZA DANYCH
            // tutaj tworze liste, zeby w trakcie dzialania aplikacji mozna bylo dodawac/aktualizaowac/usuwac PurchaseOrder
            udajeZeJestemBazaDanych = new List<PurchaseOrder>();
            udajeZeJestemBazaDanych.Add(new PurchaseOrder(getIncrementedID(), "PO012300123", DateTime.Now));
            udajeZeJestemBazaDanych.Add(new PurchaseOrder(getIncrementedID(), "PO012300123", DateTime.Now));
        }

        // TO Tez do usniecia
        private int getIncrementedID()
        {
            udajeZeJestemWygenerowanymID = udajeZeJestemWygenerowanymID + 1;
            return udajeZeJestemWygenerowanymID;
        }

        public PurchaseOrder AddPurchaseOrder(PurchaseOrder purchaseOrder)
        {
            PurchaseOrder newPurchaseOrder = new PurchaseOrder(getIncrementedID(), purchaseOrder.PurchaseOrderNumber, purchaseOrder.CreatedDate);
            udajeZeJestemBazaDanych.Add(newPurchaseOrder);
            return newPurchaseOrder;
        }

        public void DeletePurchaseOrder(int id)
        {
            udajeZeJestemBazaDanych.RemoveAll(po => po.Id == id);

        }

        public List<PurchaseOrder> GetAllPurchaseOrders()
        {
            return udajeZeJestemBazaDanych;
        }

        public PurchaseOrder UpdatePurchaseOrder(int id, PurchaseOrder purchaseOrder)
        {
            int index = udajeZeJestemBazaDanych.FindIndex(po => po.Id == id);

            if (index != -1)
            { 
                throw new ObjectNotFoundException();
            }
            udajeZeJestemBazaDanych[index] = purchaseOrder;
            return udajeZeJestemBazaDanych[index];
        }

        public PurchaseOrder GetPurchaseOrderById(int Id)
        {
            return udajeZeJestemBazaDanych.Find(po => po.Id == Id);
        }
    }
}
            