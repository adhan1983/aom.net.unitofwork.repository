namespace AOM.UnitOfWorkSln.API.Models
{
    public class Order
    {
        public int id { get; set; }
        public string Number { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
