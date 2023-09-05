using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Domain.Customers
{
    public interface ICustomerRepository
    {
        Task<Customer> GetCustomerByIdAsync(CustomerId id);
        Task Add(Customer customer);
    }
}
