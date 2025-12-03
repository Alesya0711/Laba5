using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Расчет значений уравнений ===");

            // 1. Ввод данных (переменная x)
            Console.Write("Введите значение x: ");
            string input = Console.ReadLine();

            // Проверка, что ввели число, а не текст
            if (double.TryParse(input, out double x))
            {
                // 2. Расчет уравнений

                // Уравнение 1: y = (2x - 7) / корень(3x + 21)
                double y1 = (2 * x - 7) / Math.Sqrt(3 * x + 21);

                // Уравнение 2: y = корень( x / (x - 1) )
                double y2 = Math.Sqrt(x / (x - 1));

                // Уравнение 3: y = (x + 1)/(x - 1) + корень(x^2)
                // Math.Pow(x, 2) - возведение во вторую степень
                double y3 = ((x + 1) / (x - 1)) + Math.Sqrt(Math.Pow(x, 2));

                // 3. Вывод результатов
                Console.WriteLine("\nРезультаты расчета:");

                // Выводим y1 (проверка на "не число", если корень из отрицательного)
                if (double.IsNaN(y1) || double.IsInfinity(y1))
                    Console.WriteLine($"1) y = Ошибка (недопустимое значение x для этого уравнения)");
                else
                    Console.WriteLine($"1) y = {y1:F3}"); // F3 означает 3 знака после запятой

                if (double.IsNaN(y2) || double.IsInfinity(y2))
                    Console.WriteLine($"2) y = Ошибка (недопустимое значение x для этого уравнения)");
                else
                    Console.WriteLine($"2) y = {y2:F3}");

                if (double.IsNaN(y3) || double.IsInfinity(y3))
                    Console.WriteLine($"3) y = Ошибка (деление на ноль)");
                else
                    Console.WriteLine($"3) y = {y3:F3}");
            }
            else
            {
                Console.WriteLine("Ошибка: Введите корректное число.");
            }

            // Чтобы консоль не закрылась сразу
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
