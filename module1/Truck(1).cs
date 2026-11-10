namespace Module1
{
    internal class Truck : Transport
    {
        public Truck(decimal maxWeight) : base(maxWeight)
        {
        }

        public override decimal CalculateCost(Order order)
        {
            // Базовий тариф 250 грн + 18 грн/км + 0.8 грн/кг
            return 250m + 18m * order.Distance + 0.8m * order.Weight;
        }
    }
}
