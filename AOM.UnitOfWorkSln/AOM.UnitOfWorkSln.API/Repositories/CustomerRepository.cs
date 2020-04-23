using AOM.UnitOfWorkSln.API.Data;
using AOM.UnitOfWorkSln.API.Models;
using AOM.UnitOfWorkSln.API.Interfaces;
using System.Linq;

namespace AOM.UnitOfWorkSln.API.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DataContext _context;
        public CustomerRepository(DataContext context) 
        {
            _context = context;
        }
        public Customer GetCustomer(int id)
        {
            var customer = _context.Customers.FirstOrDefault(ct => ct.Id == id);

            return customer;
        }
        public void Save(Customer customer)
        {
            _context.Customers.Add(customer);            
        }
    }
}
