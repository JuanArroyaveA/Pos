using Microsoft.EntityFrameworkCore;
using POS.Domain.Customers;

namespace POS.Application.Data
{
    internal interface IApplicationBDContex
    {
        DbSet<Customer> Customers { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
