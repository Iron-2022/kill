using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Задаем значение переменной x
            double x = 0.5;

            // Вычисляем значение функции
            double result = (Math.Sin(x) + Math.Cos(x)) / 2;

            // Выводим результат на экран
            Console.WriteLine("Результат: " + result);
        }
    }
}
