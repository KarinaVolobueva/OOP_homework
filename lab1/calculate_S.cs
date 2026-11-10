using if_positive;
using if_triangle;
using calculate_P;

namespace calculate_S
{
    public class Square
    {
        // Знаходимо площу трикутника за формулою Герона.
        public static double calculate_S(int a, int b, int c)
        {
            bool sidesArePositive = ifPositive.inputIf(a, b, c);
            bool isTriangle = ifTriangle.triangleif(a, b, c);

            if (sidesArePositive && isTriangle)
            {
                double halfPerimeter = Perimeter.calculate_P(a, b, c) / 2.0;
                double square = Math.Sqrt(
                    halfPerimeter * (halfPerimeter - a) *
                    (halfPerimeter - b) * (halfPerimeter - c));

                return square;
            }
            else
            {
                Console.WriteLine("Not positive or not triangle");
                return 0;
            }
        }
    }
}
