using System;

namespace HT_1_23sep
{
    internal static class Program
    {
        private static void Main()
        {
            int m, n, r1;
            bool isValidInput, r2, r3;
            string tmp;

            #region Input for 1.1-1.3

            // Ввод числа m
            do
            {
                Console.WriteLine("Введите целое число m");
                tmp = Console.ReadLine();
                isValidInput = int.TryParse(tmp, out m);
                if (!isValidInput)
                {
                    Console.WriteLine("Неверно введено число m!");
                }
            } while (!isValidInput);

            // Ввод числа n
            do
            {
                Console.WriteLine("Введите целое число n");
                tmp = Console.ReadLine();
                isValidInput = int.TryParse(tmp, out n);
                if (!isValidInput)
                {
                    Console.WriteLine("Неверно введено число n!");
                }
            } while (!isValidInput);

            #endregion Input for 1.1-1.3

            #region Calculating 1.1-1.3

            // Вычисление и вывод r1
            r1 = n++ * m;
            Console.WriteLine($"n++ * m = {r1}, m = {m}, n = {n}");

            // Вычисление и вывод r2
            r2 = m-- < n;
            Console.WriteLine($"m-- < n = {r2}, m = {m}, n = {n}");

            // Вычисление и вывод r3
            r3 = ++m > n;
            Console.WriteLine($"++m > n = {r3}, m = {m}, n = {n}");

            #endregion Calculating 1.1-1.3

            #region Task 1.4

            double x, y;

            // Ввод значения x
            do
            {
                Console.WriteLine("Введите вещественное число x");
                tmp = Console.ReadLine();
                isValidInput = double.TryParse(tmp, out x);
                if (!isValidInput)
                {
                    Console.WriteLine("Неверно введено число x!");
                }
            } while (!isValidInput);

            // В этом примере ОДЗ на х принадлежит области действительных чисел
            y = Math.Cos(Math.Atan(x));

            // Вывод y
            Console.WriteLine($"y = {y}");

            #endregion Task 1.4
        }
    }
}