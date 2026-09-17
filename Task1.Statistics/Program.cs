using System;

namespace Task1.Statistics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаём массив из 10 случайных чисел в диапазоне [1, 100]
            const int size = 10;
            int[] numbers = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < size; i++)
            {
                numbers[i] = rnd.Next(1, 101); // 101 не включается
            }

            // 2. Вывод массива в одну строку через string.Join
            Console.WriteLine("Массив: " + string.Join(", ", numbers));

            // 3. Сумма и произведение
            long sum = 0;
            double product = 1; // произведение может быть очень большим
            int evenCount = 0;

            foreach (int n in numbers)
            {
                sum += n;
                product *= n;
                if (n % 2 == 0) evenCount++;
            }

            // 4. Среднее арифметическое
            double average = (double)sum / size;

            // 5. Количество чисел, больших среднего
            int aboveAverage = 0;
            foreach (int n in numbers)
            {
                if (n > average) aboveAverage++;
            }

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product:E2}");
            Console.WriteLine($"Чётных чисел: {evenCount}");
            Console.WriteLine($"Больше среднего ({average:F1}): {aboveAverage}");
        }
    }
}