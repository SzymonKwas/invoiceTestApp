using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPIApp.Models
{
    public class PurchaseOrder
    {
        public PurchaseOrder(string purchaseOrderNumber, DateTime createdDate)
        {
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.CreatedDate = createdDate;
        }

        public PurchaseOrder(int id, string purchaseOrderNumber, DateTime createdDate)
        {
            this.Id = id;
            this.PurchaseOrderNumber = purchaseOrderNumber;
            this.CreatedDate = createdDate;
        }

        public int Id { get; set; } // ID nadawane jest przy zapisie do bazy danych oczywiscie http://www.firebirdfaq.org/faq29/ . Jesli byloby potrzebne to trzeba znalezc jak to skonfigurowac dla .NET
        public string PurchaseOrderNumber { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}