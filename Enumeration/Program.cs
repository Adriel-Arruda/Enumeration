using Enumeration.Entities;
using Enumeration.Entities.Enums;
namespace Enumeration
{
    public static class Enumeration
    {
        public static void Main(string[] args)
        {
            Order order = new Order
            {
                Id = 001,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };
            Console.WriteLine(order);
        }
    }
}