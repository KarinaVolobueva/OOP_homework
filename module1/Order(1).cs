namespace Module1
{
    internal class Order
    {
        public int Number { get; private set; }
        public string Description { get; private set; }
        public decimal Weight { get; private set; }
        public decimal Distance { get; private set; }

        public Order(int number, string description, decimal weight, decimal distance)
        {
            if (number <= 0)
            {
                throw new ArgumentException("Номер замовлення повинен бути більшим за нуль.", nameof(number));
            }
            Number = number;

            if (string.IsNullOrWhiteSpace(description))
            {
                throw new ArgumentException("Опис не повинен бути порожнім.", nameof(description));
            }
            Description = description.Trim();

            if (weight <= 0)
            {
                throw new ArgumentException("Вага повинна бути більшою за нуль.", nameof(weight));
            }
            Weight = weight;

            if (distance <= 0)
            {
                throw new ArgumentException("Відстань повинна бути більшою за нуль.", nameof(distance));
            }
            Distance = distance;
        }

        public override string ToString()
        {
            return $"№{Number} — '{Description}' ({Weight} кг, {Distance} км)";
        }
    }
}
