namespace if_positive
{
    public class ifPositive
    {
        // Перевіряємо, чи всі три сторони мають додатні значення.
        public static bool inputIf(int a, int b, int c)
        {
            if (a > 0 && b > 0 && c > 0)
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
