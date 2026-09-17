// Вариант 0. Успеваемость студентов
using System;

namespace Final.Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Анна", "Борис", "Виктор", "Галина" };
            int[] grades      = { 85, 92, 78, 95 };

            // 1. Таблица «имя — баллы» с выравниванием
            Console.WriteLine("Студент  | Баллы");
            Console.WriteLine("---------+------");
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine($"{students[i],-8} | {grades[i],5}");
            }
            Console.WriteLine();

            // 2. Лучший студент через Max + IndexOf
            int maxGrade = 0;
            foreach (int g in grades)
            {
                if (g > maxGrade) maxGrade = g;
            }
            int bestIndex = Array.IndexOf(grades, maxGrade);

            Console.WriteLine($"Лучший студент: {students[bestIndex]} ({maxGrade} баллов)");

            // 3. Средний балл группы
            double sum = 0;
            foreach (int g in grades) sum += g;
            double avg = sum / grades.Length;
            Console.WriteLine($"Средний балл группы: {avg:F2}");
        }
    }
}