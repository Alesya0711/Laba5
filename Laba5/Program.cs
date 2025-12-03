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
            Console.WriteLine("=== Расчет значений уравнения ===");

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
