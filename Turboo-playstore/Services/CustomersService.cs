using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Turboo_playstore.Repositories.Interfaces;
using Turboo_playstore.Services.Interfaces;

namespace Turboo_playstore.Services
{
    public class CustomersService : ICustomersService
    {
        private readonly ICustomerRepository _customerRepository;
        public CustomersService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
    }
}
