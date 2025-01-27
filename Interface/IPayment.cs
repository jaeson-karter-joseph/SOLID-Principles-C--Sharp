using SolidPrinciples.Models;

namespace SolidPrinciples.Interface
{
    //ISP
    public interface IPayment
    {
        public void ProcessPayment(Order order);
    }
}
