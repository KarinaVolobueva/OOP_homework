namespace Module1
{
    internal class CashPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"[Готівка] Оплачено суму: {amount:F2} грн.");
        }
    }
}
