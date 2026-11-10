namespace Lr3
{
    internal class Hunter
    {
        private string _name;
        private Health _health;
        private int _gold;
        private int _arrows;
        private int _loot;

        public string Name => _name;
        public int Gold => _gold;
        public int Arrows => _arrows;
        public int Loot => _loot;
        public bool IsAlive => _health.CurrentHealth > 0;

        // У програмі є мисливець, який має ім’я, певну кількість здоров’я, золота та стріл.
        public Hunter(string name, int health, int gold, int arrows)
        {
            _name = name;
            _health = new Health(health);
            _gold = gold;
            _arrows = arrows;
            _loot = 0;
        }
        // втрачати здоров’я під час полювання;
        public void TakeDamage(int damage)
        {
            _health.TakeDamage(damage);
            if(_health.CurrentHealth <= 0)
            {
                Die();
            }
        }
        private void Die()
        {
            Console.WriteLine($"{_name} has died.");
        }
        // полювати, використовуючи стріли;
        public void UseArrow()
        {
            if (_arrows > 0) _arrows--;
        }

        public void AddArrows(int count)
        {
            _arrows += count;
        }

        public void AddGold(int amount)
        {
            _gold += amount;
        }

        public void SpendGold(int amount)
        {
            _gold -= amount;
        }
        // отримувати здобич і винагороду за успішне полювання;

        public void AddLoot(int amount)
        {
            _loot += amount;
        }
        // переглядати поточну інформацію про себе.
        public void ShowInfo()
        {
            Console.WriteLine($"Hunter: {_name} :  Health: {_health.CurrentHealth} Gold: {_gold} Arrows: {_arrows} Loot: {_loot}");
        }
    }
}
