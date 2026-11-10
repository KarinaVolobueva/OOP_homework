using if_positive;
using if_triangle;

namespace calculate_P
{
    public class Perimeter
    {
        // Обчислюємо периметр, якщо задані сторони утворюють трикутник.
        public static int calculate_P(int a, int b, int c)
        {
            bool sidesArePositive = ifPositive.inputIf(a, b, c);
            bool isTriangle = ifTriangle.triangleif(a, b, c);

            if (sidesArePositive && isTriangle)
            {
                int perimeter = a + b + c;
                return perimeter;
            }
            else
            {
                Console.WriteLine("Not positive or not triangle");
                return 0;
            }
        }
    }
}
