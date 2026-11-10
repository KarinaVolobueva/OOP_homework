// Завдання: «Мисливець»
// Створіть консольну програму, яка моделює роботу мисливця.
// У програмі є мисливець, який має ім’я, певну кількість здоров’я, золота та стріл.
// Мисливець повинен мати можливість:
// полювати, використовуючи стріли;
// отримувати здобич і винагороду за успішне полювання;
// втрачати здоров’я під час полювання;
// купувати стріли за золото;
// переглядати поточну інформацію про себе.
// На початку програми необхідно вивести інформацію про мисливця: його ім’я, кількість здоров’я, золота та стріл.
// Під час роботи програми користувач може виконувати доступні дії з мисливцем. Результат кожної дії повинен відображатися в консолі.
// Додаткове завдання
// Додайте до програми другого мисливця.
// Два мисливці змагаються між собою: кожен вирушає на полювання та намагається отримати якомога більше здобичі.
// На початку програми необхідно вивести інформацію про обох мисливців.
// Після завершення змагання програма повинна:
// Вивести результати полювання кожного мисливця.
// Порівняти кількість здобичі.
// Вивести ім'я переможця.
// Якщо мисливці отримали однакову кількість здобичі — повідомити про нічию.

namespace Lr3
{
    internal class ProgramTEST
    {
        // static void Main(string[] args)
        // {
        //     Hunter hunter1 = new Hunter("Hunter1", 100, 50, 10);
        //     Hunter hunter2 = new Hunter("Hunter2", 100, 50, 10);

        //     // На початку програми необхідно вивести інформацію про мисливця: його ім’я, кількість здоров’я, золота та стріл.
        //     Console.WriteLine("Hunters' info");
        //     hunter1.ShowInfo();
        //     hunter2.ShowInfo();
        //     Console.WriteLine();

        //     Console.WriteLine("Competition starts!");
        //     for (int i = 1; i <= 3; i++)
        //     {
        //         Console.WriteLine($"Round {i}");
        //         Hunt.ExecuteHunt(hunter1);
        //         Hunt.ExecuteHunt(hunter2);
        //     }

        //     Console.WriteLine();
        //     Console.WriteLine($"{hunter1} buys arrows!");
        //     Shop.BuyArrows(hunter1, 4);

        //     Console.WriteLine();
        //     Console.WriteLine($"Results!");
        //     hunter1.ShowInfo();
        //     hunter2.ShowInfo();
        //     Console.WriteLine();


        //     if (hunter1.Loot > hunter2.Loot)
        //     {
        //         Console.WriteLine($"Winner is: {hunter1.Name}, they got: {hunter1.Loot} loot!");
        //     }
        //     else if (hunter2.Loot > hunter1.Loot)
        //     {
        //         Console.WriteLine($"Winner is: {hunter2.Name}, they got: {hunter2.Loot} loot!");
        //     }
        //     else
        //     {
        //         Console.WriteLine($"Tie! Both got same amount of loot: {hunter1.Loot}.");
        //     }
        // }
    }
}