using OrderApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace OrderApp.Domain.Interfaces
{
    public interface ICustomerRepository : IRepository<Customer>
    {
        Task<Customer> GetCustomerAndOrders(Guid id);
    }
}
