using AOM.UnitOfWorkSln.API.Models;

namespace AOM.UnitOfWorkSln.API.Interfaces
{
    public interface IOrderRepository
    {
        void Save(Order order);

        Order GetOrder(int id);
    }
}
