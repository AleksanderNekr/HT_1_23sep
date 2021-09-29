﻿using System;

namespace Task2
{
    internal static class Program
    {
        private static void Main()
        {
            string tmp;
            bool isValidInput;
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

            var isInArea = x >= 0 && y >= -7 && x <= 5 && x + y <= 5;
            Console.WriteLine(isInArea);
        }
    }
}