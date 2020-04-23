using AOM.UnitOfWorkSln.API.Models;

namespace AOM.UnitOfWorkSln.API.Interfaces
{
    public interface ICustomerRepository
    {
        void Save(Customer customer);
        Customer GetCustomer(int id);

    }
}
