namespace SPG_Fachtheorie.Aufgabe1.Model
{
    public class PaymentItem
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }

        public PaymentItem(int amount, decimal price)
        {
            Amount = amount;
            Price = price;
        }
    }
}