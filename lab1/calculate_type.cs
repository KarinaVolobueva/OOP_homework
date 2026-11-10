using if_positive;
using if_triangle;

namespace calculate_type
{
    public class calculateType
    {
        // Визначаємо тип трикутника за довжинами його сторін.
        public static string typeCalculate(int a, int b, int c)
        {
            bool sidesArePositive = ifPositive.inputIf(a, b, c);
            bool isTriangle = ifTriangle.triangleif(a, b, c);

            if (sidesArePositive && isTriangle)
            {
                if (a == b && b == c)
                {
                    return "Рівносторонній";
                }
                else if (a == b || b == c || c == a)
                {
                    return "Рівнобедренний";
                }
                else if ((Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2)) ||
                         (Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2)) ||
                         (Math.Pow(c, 2) + Math.Pow(b, 2) == Math.Pow(a, 2)))
                {
                    return "Прямокутний";
                }
                else
                {
                    return "Довільний";
                }
            }
            else
            {
                return "Not positive or not triangle";
            }
        }
    }
}
