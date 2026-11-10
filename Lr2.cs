using System;
namespace Lr2
{
    class Program
    {
        static void Main()
        {
            // Умова:На потоці є кілька груп (3-5).
            // Кожна група містить від 10 до 30 
            // студентів. Оцінки студентів задані у 
            // вигляді зубчастого масиву int[][], 
            // де кожен елемент — це масив оцінок 
            // однієї підгрупи. Завдання Для кожної 
            // групи та для потоку знайти:середній бал,
            // мінімальну оцінку,максимальну оцінку.

            // 1. Ініціалізація зубчастого масиву
            //(4 підгрупи з різною кількістю студентів)
            int[][] streamGrades = new int[][]
            {
                new int[] {85, 90, 78, 92, 88, 76, 95, 89, 84, 91},
                new int[] {60, 75, 82, 68, 90, 73, 85, 80, 95, 70, 88, 64},
                new int[] {95, 98, 92, 100, 89, 94, 91, 96, 88, 90, 93, 97, 85, 99, 92},
                new int[] {70, 65, 80, 72, 88, 91, 60, 78, 84, 76, 82}
            };
            int streamTotalSum = 0;
            int streamTotalCount = 0;
            int streamMin = streamGrades[0][0];
            int streamMax = streamGrades[0][0];
            Console.WriteLine("=== СТАТИСТИКА ПО ГРУПАХ ===");

            for (int i = 0; i < streamGrades.Length; i++)
            {
            int groupSum = 0;

            // Для кожної групи ініціалізуємо локальні min/max
            // першою оцінкою цієї групи
            int groupMin = streamGrades[i][0];
            int groupMax = streamGrades[i][0];

            for (int j = 0; j < streamGrades[i].Length; j++)
            {
                int grade = streamGrades[i][j];
                // Накопичуємо суму оцінок групи
                groupSum += grade;

                //ПОШУК MIN / MAX ДЛЯ ПОТОЧНОЇ ГРУПИ
                if (grade < groupMin)
                {
                    groupMin = grade;
                }

                if (grade > groupMax)
                {
                    groupMax = grade;
                }

                //ПОШУК MIN / MAX ДЛЯ ВСЬОГО ПОТОКУ
                if (grade < streamMin)
                {
                    streamMin = grade;
                }

                if (grade > streamMax)
                {
                    streamMax = grade;
                }
            }

            // Накопичуємо загальну суму та кількість для потоку
            streamTotalSum += groupSum;
            streamTotalCount += streamGrades[i].Length;
            //середній бал групи
            double groupAverage = (double)groupSum / streamGrades[i].Length;
            
            Console.WriteLine($"Група №{i + 1} (студентів: {streamGrades[i].Length}):");
            Console.WriteLine($"  • Середній бал:    {groupAverage:F2}");
            Console.WriteLine($"  • Мінімальна оцінка: {groupMin}");
            Console.WriteLine($"  • Максимальна оцінка: {groupMax}\n");
            }
            //середній бал потоку
            double streamAverage = (double)streamTotalSum / streamTotalCount;

            Console.WriteLine("===============================");
            Console.WriteLine($"Всього студентів:    {streamTotalCount}");
            Console.WriteLine($"Середній бал потоку: {streamAverage:F2}");
            Console.WriteLine($"Мінімальна оцінка:  {streamMin}");
            Console.WriteLine($"Максимальна оцінка: {streamMax}");
            
        }
    }
}