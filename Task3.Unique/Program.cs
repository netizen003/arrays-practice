using System;

namespace Task3.Unique
{
    internal class Program
    {
        // Возвращает массив уникальных элементов исходного массива,
        // сохраняя порядок первого появления. Без LINQ и HashSet.
        public static int[] GetUnique(int[] source)
        {
            // Вспомогательный массив той же длины — больше уникальных быть не может
            int[] temp = new int[source.Length];
            int uniqueCount = 0;

            for (int i = 0; i < source.Length; i++)
            {
                bool alreadyExists = false;

                // Проверяем, встречался ли элемент ранее
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (temp[j] == source[i])
                    {
                        alreadyExists = true;
                        break;
                    }
                }

                if (!alreadyExists)
                {
                    temp[uniqueCount] = source[i];
                    uniqueCount++;
                }
            }

            // Формируем итоговый массив точной длины
            int[] result = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                result[i] = temp[i];
            }
            return result;
        }

        static void Main(string[] args)
        {
            int[] source = { 1, 2, 2, 3, 4, 4, 4, 5 };

            Console.WriteLine("Исходный:  " + string.Join(", ", source));
            int[] unique = GetUnique(source);
            Console.WriteLine("Уникальные: " + string.Join(", ", unique));
        }
    }
}