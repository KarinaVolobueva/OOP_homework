namespace Module1
{
    internal class DeliveryService
    {
        private readonly List<Transport> _transports = new List<Transport>();
        private readonly List<Order> _activeOrders = new List<Order>();
        private readonly List<Order> _deliveryHistory = new List<Order>();
        private readonly Dictionary<Order, Transport> _assignments = new Dictionary<Order, Transport>();

        public void AddTransport(Transport transport)
        {
            if (transport == null) return;
            _transports.Add(transport);
        }

        public void AddOrder(Order order)
        {
            if (order == null) return;

            if (_activeOrders.Any(o => o.Number == order.Number) || _deliveryHistory.Any(o => o.Number == order.Number))
            {
                Console.WriteLine($"[Помилка] Замовлення з номером №{order.Number} вже існує!");
                return;
            }

            _activeOrders.Add(order);
        }

        public void AssignOrder(Order order, Transport transport)
        {
            if (!_transports.Contains(transport))
            {
                Console.WriteLine("[Помилка] Транспорт не зареєстрований.");
                return;
            }
            if (!_activeOrders.Contains(order))
            {
                Console.WriteLine("[Помилка] Замовлення не зареєстроване.");
                return;
            }
            if (transport.IsBusy)
            {
                Console.WriteLine("[Помилка] Транспорт уже зайнятий.");
                return;
            }
            if (!transport.CanTake(order))
            {
                Console.WriteLine($"[Помилка] Транспорт {transport.GetType().Name} не може прийняти вагу {order.Weight} кг.");
                return;
            }
            if (_assignments.ContainsKey(order))
            {
                Console.WriteLine("[Помилка] Це замовлення вже призначене.");
                return;
            }

            _assignments.Add(order, transport);
            transport.MarkBusy();
            Console.WriteLine($"Замовлення №{order.Number} успішно призначено на {transport.GetType().Name}.");
        }

        public void CompleteDelivery(Order order, IPayment payment)
        {
            if (!_assignments.ContainsKey(order))
            {
                Console.WriteLine("[Помилка] Призначення для даного замовлення не знайдено.");
                return;
            }

            Transport transport = _assignments[order];
            decimal cost = transport.CalculateCost(order);
            
            payment.Pay(cost);
            
            transport.MarkFree();
            _assignments.Remove(order);
            _activeOrders.Remove(order);
            _deliveryHistory.Add(order);
        }

        public void ShowActiveOrders()
        {
            if (!_activeOrders.Any())
            {
                Console.WriteLine("Немає активних замовлень.");
                return;
            }

            foreach (Order order in _activeOrders)
            {
                Console.WriteLine(order);
            }
        }

        public void ShowDeliveryHistory()
        {
            if (!_deliveryHistory.Any())
            {
                Console.WriteLine("Історія доставок порожня.");
                return;
            }

            foreach (Order order in _deliveryHistory)
            {
                Console.WriteLine(order);
            }
        }

        public void ShowAvailableCosts(Order order)
        {
            foreach (Transport transport in _transports)
            {
                if (transport.CanTake(order))
                {
                    Console.WriteLine($"  - {transport.GetType().Name}: {transport.CalculateCost(order)} грн");
                }
            }
        }
    }
}
