namespace input
{
    public class inputUser
    {
        // Зчитуємо значення трьох сторін з консолі.
        public static (int a, int b, int c) userInput()
        {
            Console.Write("Enter a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter c: ");
            int c = Convert.ToInt32(Console.ReadLine());

            return (a, b, c);
        }
    }
}
