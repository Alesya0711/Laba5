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

            // Чтобы консоль не закрылась сразу
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}
