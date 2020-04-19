using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using InvoiceAPIApp.Models;
using InvoiceAPIApp.Repository.Invoice;

namespace InvoiceAPIApp.Services.InvoiceService
{
    public class InvoiceServiceImpl : InvoiceService, InvoiceRepository
    {
        private readonly InvoiceRepository _invoiceRepository;

        public InvoiceServiceImpl(InvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }

        public List<Invoice> getAllInvoices()
        {
            throw new NotImplementedException();
        }
    }
}