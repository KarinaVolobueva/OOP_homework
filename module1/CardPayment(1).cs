namespace Module1
{
    internal class CardPayment : IPayment
    {
        public void Pay(decimal amount)
        {
            Console.WriteLine($"[Картка] Успішно списано: {amount:F2} грн.");
        }
    }
}
