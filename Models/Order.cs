namespace SolidPrinciples.Models
{
    //Single Responsibility Principle
    public class Order(int OrderId, string CustomerName, double Amount)
    {
        public int OrderId { get; set; } = OrderId;
        public string CustomerName { get; set; } = CustomerName;
        public double Amount { get; set; } = Amount;
    }
}
