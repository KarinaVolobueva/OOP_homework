using System;

namespace Lr3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hunter hunter1 = new Hunter("hunter1", 100, 50, 10);
            Hunter hunter2 = new Hunter("hunter2", 100, 50, 10);

            Console.WriteLine("Info:");
            hunter1.ShowInfo();
            hunter2.ShowInfo();
            Console.WriteLine();

            bool competitionRunning = true;
            int round = 1;

            while (competitionRunning)
            {
                Console.WriteLine("Round 1");

                bool hunter1Turn = true;
                while (hunter1Turn && hunter1.IsAlive)
                {
                    Console.WriteLine("Player 1's Turn: {hunter1.Name}");
                    hunter1.ShowInfo();
                    Console.WriteLine("Menu:");
                    Console.WriteLine("\nChoose action:");
                    Console.WriteLine("1 - Hunt");
                    Console.WriteLine("2 - Buy arrows");
                    Console.WriteLine("3 - Show info");
                    Console.WriteLine("4 - Skip turn");
                    Console.Write("Your choice: ");

                    string choice = Console.ReadLine();
                    Console.WriteLine();

                    switch (choice)
                {
                    case "1":
                        Hunt.ExecuteHunt(hunter1);
                        hunter1Turn = false;
                        break;
                    case "2":
                        Console.Write("How many arrows do you wanna buy? (1 arrow = 5 gold): ");
                        if (int.TryParse(Console.ReadLine(), out int arrowCount1))
                        {
                            Shop.BuyArrows(hunter1, arrowCount1);
                        }
                        else
                        {
                            Console.WriteLine("Error! Try again.");
                        }
                        break;
                    case "3":
                        hunter1.ShowInfo();
                        break;
                    case "4":
                        Console.WriteLine("{hunter1.Name} skips their turn");
                        hunter1Turn = false;
                        break;
                    default:
                        Console.WriteLine("Choose a number in range 1-4.");
                        break;
                }

                if (!hunter1.IsAlive)
                {
                    Console.WriteLine("\nGame over. You died.");
                    break;
                }
                }

                bool hunter2Turn = true;
                while (hunter2Turn && hunter2.IsAlive)
                {
                    Console.WriteLine("Player 2's Turn: {hunter2.Name}");
                    hunter2.ShowInfo();
                    Console.WriteLine("Menu:");
                    Console.WriteLine("\nChoose action:");
                    Console.WriteLine("1 - Hunt");
                    Console.WriteLine("2 - Buy arrows");
                    Console.WriteLine("3 - Show info");
                    Console.WriteLine("4 - Skip turn");
                    Console.Write("Your choice: ");

                    string choice = Console.ReadLine();
                    Console.WriteLine();

                    switch (choice)
                {
                    case "1":
                        Hunt.ExecuteHunt(hunter2);
                        hunter2Turn = false;
                        break;
                    case "2":
                        Console.Write("How many arrows do you wanna buy? (1 arrow = 5 gold): ");
                        if (int.TryParse(Console.ReadLine(), out int arrowCount2))
                        {
                            Shop.BuyArrows(hunter2, arrowCount2);
                        }
                        else
                        {
                            Console.WriteLine("Error! Try again.");
                        }
                        break;
                    case "3":
                        hunter2.ShowInfo();
                        break;
                    case "4":
                        Console.WriteLine("{hunter2.Name} skips their turn");
                        hunter2Turn = false;
                        break;
                    default:
                        Console.WriteLine("Choose a number in range 1-4.");
                        break;
                }

                if (!hunter2.IsAlive)
                {
                    Console.WriteLine("\nGame over. You died.");
                    break;
                }
                }
                Console.WriteLine("\nRound {round} results");
                hunter1.ShowInfo();
                hunter2.ShowInfo();

                Console.Write("\nYou want a new round? (1 - Yes, 0 - No): ");
                string nextRoundChoice = Console.ReadLine();
                if (nextRoundChoice == "0")
                {
                    competitionRunning = false;
                }
                round++;
            }
            Console.WriteLine();
            Console.WriteLine("\nFinal results");
            Console.WriteLine();
            hunter1.ShowInfo();
            hunter2.ShowInfo();
            Console.WriteLine();

            if (hunter1.Loot > hunter2.Loot)
            {
                Console.WriteLine($"Winner is: {hunter1.Name} looted: {hunter1.Loot}! (while {hunter2.Name} has looted {hunter2.Loot})");
            }
            else if (hunter2.Loot > hunter1.Loot)
            {
                Console.WriteLine($"Winner is: {hunter2.Name} looted: {hunter2.Loot}! (while {hunter1.Name} has looted {hunter1.Loot})");
            }
            else
            {
                Console.WriteLine($"Tie! Both looted same amount: {hunter1.Loot}.");
            }
            Console.WriteLine();
        }
    }
}