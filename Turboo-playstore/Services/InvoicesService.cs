using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Repositories.Interfaces;
using Turboo_playstore.Services.Interfaces;

namespace Turboo_playstore.Services
{
    public class InvoicesService : IInvoicesService
    {
        private readonly IInvoiceRepository _invoiceRepository;
        public InvoicesService(IInvoiceRepository invoiceRepository)
        {
            _invoiceRepository = invoiceRepository;
        }
    }
}
