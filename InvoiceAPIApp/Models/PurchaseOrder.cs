using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace InvoiceAPIApp.Models
{
    public class PurchaseOrder
    {
        int id { get; set; }
        string purchaseOrderNumber { get; set; }
        DateTime createdDate { get; set; }
    }
}