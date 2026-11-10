using System;

namespace Lr3
{
    internal static class Shop
    {
        private const int ArrowCost = 5;

        public static void BuyArrows(Hunter hunter, int count)
        {
            int totalPrice = count * ArrowCost;

            if (hunter.Gold >= totalPrice)
            {
                // купувати стріли за золото;
                hunter.SpendGold(totalPrice);
                hunter.AddArrows(count);
                Console.WriteLine($"Shop: {hunter.Name} sucessfully bought {count} arrows for {totalPrice} gold.");
            }
            else
            {
                Console.WriteLine($"Shop: {hunter.Name} does not have enough godl! Total is {totalPrice}, You have {hunter.Gold}.");
            }
        }
    }
}