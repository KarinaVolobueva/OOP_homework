namespace Module1
{
    abstract class Transport
    {
        public decimal MaxWeight { get; private set; }
        public bool IsBusy { get; private set; }

        public Transport(decimal maxWeight)
        {
            if (maxWeight <= 0)
                throw new ArgumentException("Максимальна вага повинна бути більшою за нуль.", nameof(maxWeight));

            MaxWeight = maxWeight;
        }

        public abstract decimal CalculateCost(Order order);

        public virtual bool CanTake(Order order)
        {
            return order != null && order.Weight <= MaxWeight;
        }

        public void MarkBusy()
        {
            IsBusy = true;
        }

        public void MarkFree()
        {
            IsBusy = false;
        }
    }
}
