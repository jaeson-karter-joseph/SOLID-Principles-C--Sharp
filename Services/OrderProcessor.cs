using SolidPrinciples.Interface;
using SolidPrinciples.Models;

namespace SolidPrinciples.Services
{
    internal class OrderProcessor(IPayment payment)
    {
        public void ProcessOrder(Order order)
        {
            Console.WriteLine($"Order {order.OrderId} placed by {order.CustomerName}");
            payment.ProcessPayment(order);
            Console.WriteLine("Order processed successfully!\n");
        }
    }
}
