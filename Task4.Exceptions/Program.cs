using System;

namespace Task4.Exceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int size = 5;
            int[] arr = new int[size];

            // 1. Заполнение массива с обработкой исключений
            for (int i = 0; i < size; i++)
            {
                while (true)
                {
                    Console.Write($"Введите элемент [{i}]: ");
                    try
                    {
                        arr[i] = int.Parse(Console.ReadLine());
                        break; // успешно — переходим к следующему
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число слишком большое!");
                    }
                }
            }

            Console.WriteLine("Массив: " + string.Join(", ", arr));

            // 2. Запрос индекса с обработкой IndexOutOfRangeException
            while (true)
            {
                Console.Write($"Введите индекс для вывода (0-{size - 1}): ");
                try
                {
                    int index = int.Parse(Console.ReadLine());
                    Console.WriteLine($"Элемент [{index}] = {arr[index]}");
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Ошибка: Индекс вне границ массива.");
                }
            }
        }
    }
}