
using SolidPrinciples.Models;
using SolidPrinciples.PaymentMethods;
using SolidPrinciples.Services;

namespace SolidPrinciples
{
    public class Program
    {
        public static void Main()
        {
            Order orderOne = new(101, "Jaeson", 500.00);
            Order orderTow = new(102, "Roshan", 10.00);
            Order orderThree = new(103, "Joseph", 89.90);

            OrderProcessor creditCardProcessor = new(new CreditCardPayment());
            creditCardProcessor.ProcessOrder(orderOne);

            OrderProcessor payPalProcessor  = new(new PayPalPayment());
            payPalProcessor.ProcessOrder(orderTow);

            OrderProcessor UpiPayment = new(new UpiPayment());
            UpiPayment.ProcessOrder(orderThree);

        }
    }
}