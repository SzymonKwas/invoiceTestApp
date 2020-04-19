using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace InvoiceAPIApp.Models
{
    [DataContract]
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
        [DataMember]
        public int Id { get; set; } // ID nadawane jest przy zapisie do bazy danych oczywiscie http://www.firebirdfaq.org/faq29/ . Jesli byloby potrzebne to trzeba znalezc jak to skonfigurowac dla .NET
        [DataMember]
        public string PurchaseOrderNumber { get; set; }
        [DataMember]
        public DateTime CreatedDate { get; set; }
    }
}