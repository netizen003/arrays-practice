using System;

namespace Task2.InputSort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Запрос количества элементов с проверкой N > 0
            int n;
            while (true)
            {
                Console.Write("Введите количество элементов: ");
                string input = Console.ReadLine();

                try
                {
                    n = int.Parse(input);
                    if (n > 0) break;
                    Console.WriteLine("Ошибка: число должно быть больше 0.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: число слишком большое!");
                }
            }

            // 2. Заполнение массива с обработкой исключений
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент [{i}]: ");
                    try
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: число слишком большое!");
                    }
                }
            }

            // 3. Исходный массив
            Console.WriteLine();
            Console.WriteLine("Исходный массив:  " + string.Join(", ", arr));

            // 4. Обратный порядок
            int[] reversed = new int[n];
            for (int i = 0; i < n; i++)
            {
                reversed[i] = arr[n - 1 - i];
            }
            Console.WriteLine("Обратный порядок: " + string.Join(", ", reversed));

            // 5. Сортировка по возрастанию
            int[] sorted = (int[])arr.Clone();
            Array.Sort(sorted);
            Console.WriteLine("Отсортированный:  " + string.Join(", ", sorted));

            // 6. Максимум и минимум без LINQ
            int max = arr[0];
            int min = arr[0];
            for (int i = 1; i < n; i++)
            {
                if (arr[i] > max) max = arr[i];
                if (arr[i] < min) min = arr[i];
            }

            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}