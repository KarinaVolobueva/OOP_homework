namespace if_triangle
{
    public class ifTriangle
    {
        // Перевіряємо виконання нерівностей трикутника.
        public static bool triangleif(int a, int b, int c)
        {
            if ((a + b > c) && (a + c > b) && (b + c > a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
