using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InvoiceAPIApp.Models;

namespace InvoiceAPIApp.Services.InvoiceService
{
    interface IInvoiceService
    {
        List<Invoice> getAllInvoices();
    }
}
