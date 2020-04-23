using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AOM.UnitOfWorkSln.API.Models;
using AOM.UnitOfWorkSln.API.Interfaces;

namespace AOM.UnitOfWorkSln.API.Controllers
{
    
    [ApiController]
    [Route("api/v1/orders")]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        private readonly ICustomerRepository _customerRepository;
        private readonly IUnitOfWork _unitOfWork;
        public OrderController(
            IOrderRepository orderRepository, 
            ICustomerRepository customerRepository,
            IUnitOfWork unitOfWork

            ) 
        {
            _orderRepository = orderRepository;
            _customerRepository = customerRepository;
            _unitOfWork = unitOfWork;
        }

        [HttpPost]
        [Route("")]
        public async Task<IActionResult> Post()            
        {
            var customer = new Customer() { Name = "Adhan Maldonado" };

            var order = new Order() { Customer = customer, Number = "123" };

            _customerRepository.Save(customer);

            _orderRepository.Save(order);

            _unitOfWork.Commit();

            return StatusCode((int)HttpStatusCode.Created, order);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> Get([FromRoute]int id)
        {
            var order = _orderRepository.GetOrder(id);

            return StatusCode((int)HttpStatusCode.OK, order);
        }
    }
}