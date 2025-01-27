using SolidPrinciples.Interface;
using SolidPrinciples.Models;

namespace SolidPrinciples.PaymentMethods
{
    //Open/Closed Principle(OCP)
    public class CreditCardPayment : IPayment
    {
        public void ProcessPayment(Order order)
        {
            Console.WriteLine($"Processing UPI payment for Order {order.OrderId} of amount ${order.Amount}");
        }
    }
}
