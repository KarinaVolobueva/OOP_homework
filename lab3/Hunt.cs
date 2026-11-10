using System;

namespace Lr3
{
    internal static class Hunt
    {
        private static readonly Random Rand = new Random();

        public static void ExecuteHunt(Hunter hunter)
        {
            if (!hunter.IsAlive)
            {
                Console.WriteLine($"{hunter.Name} has died.");
                return;
            }

            if (hunter.Arrows <= 0)
            {
                Console.WriteLine($"{hunter.Name} does not have any arrows left! Has to buy some.");
                return;
            }

            hunter.UseArrow();

            // Шанс успіху 50%
            bool isSuccessful = Rand.Next(0, 2) == 1;

            if (isSuccessful)
            {
                int goldEarned = Rand.Next(5, 16);
                int lootEarned = Rand.Next(1, 4);

                hunter.AddGold(goldEarned);
                hunter.AddLoot(lootEarned);

                Console.WriteLine($"{hunter.Name}'s hunt was sucessful! Loot earned: {lootEarned}, Gold earned: {goldEarned}.");
            }
            else
            {
                int damageTaken = Rand.Next(10, 26);
                hunter.TakeDamage(damageTaken);

                Console.WriteLine($"{hunter.Name} lost {damageTaken} of their health!");
            }
        }
    }
}