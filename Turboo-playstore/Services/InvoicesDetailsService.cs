using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Repositories;
using Turboo_playstore.Repositories.Interfaces;
using Turboo_playstore.Services.Interfaces;

namespace Turboo_playstore.Services
{
    public class InvoicesDetailsService : IInvoicesDetailsService
    {
        private readonly IInvoiceDetailsRepository _invoiceDetailsRepository;
        public InvoicesDetailsService(IInvoiceDetailsRepository invoiceDetailsRepository)
        {
            _invoiceDetailsRepository = invoiceDetailsRepository;
        }
    }
}
