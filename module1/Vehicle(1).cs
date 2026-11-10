namespace Module1
{
    internal class Car : Transport
    {
        public Car(decimal maxWeight) : base(maxWeight)
        {
        }

        public override decimal CalculateCost(Order order)
        {
            // Базовий тариф 60 грн + 10 грн/км + 1.2 грн/кг
            return 60m + 10m * order.Distance + 1.2m * order.Weight;
        }
    }
}
