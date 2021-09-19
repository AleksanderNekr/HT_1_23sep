using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string tmp;
            bool isValidInput, isInArea;
            double x, y;

            do
            {
                Console.WriteLine("Введите координату Х");
                tmp = Console.ReadLine();
                isValidInput = double.TryParse(tmp, out x);
                if (!isValidInput)
                {
                    Console.WriteLine("Неверно введена координата Х!");
                }
            } while (!isValidInput);

            do
            {
                Console.WriteLine("Введите координату Y");
                tmp = Console.ReadLine();
                isValidInput = double.TryParse(tmp, out y);
                if (!isValidInput)
                {
                    Console.WriteLine("Неверно введена координата Y!");
                }
            } while (!isValidInput);

            isInArea = x >= 0 && y >= -7 && x <= 5 && x + y <= 5;
            Console.WriteLine(isInArea);
        }
    }
}
