using System;

namespace Task2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string tmp;
            bool isValidInput, isInArea;
            double x, y;

            #region Input

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

            #endregion Input

            isInArea = x >= 0 && y >= -7 && x <= 5 && x + y <= 5;
            Console.WriteLine(isInArea);
        }
    }
}