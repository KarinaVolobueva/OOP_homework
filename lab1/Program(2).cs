using System;
using input;
using if_positive;
using if_triangle;
using calculate_P;
using calculate_S;
using calculate_type;

namespace Lr1
{
    internal class Program
    {
        static void Main()
        {
            // Отримуємо довжини сторін трикутника.
            var (a, b, c) = inputUser.userInput();

            Console.WriteLine("\n=== Results ===");

            // Перевіряємо, чи можна побудувати трикутник.
            bool isPositive = ifPositive.inputIf(a, b, c);
            bool isTriangle = ifTriangle.triangleif(a, b, c);

            if (isPositive && isTriangle)
            {
                int perimeter = Perimeter.calculate_P(a, b, c);
                double square = Square.calculate_S(a, b, c);
                string type = calculateType.typeCalculate(a, b, c);

                Console.WriteLine($"Perimeter is {perimeter}");
                Console.WriteLine($"Square is {square:F2}");
                Console.WriteLine($"Type is {type}");
            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
