using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HT_1_23sep
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            int m, n, resultTask1_1;
            bool isValidInput, resultTask1_2, resultTask1_3;
            string tmp;

            #region Input for 1.1-1.3
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
            #endregion

            #region Calculating 1.1-1.3
            resultTask1_1 = n++ * m;
            Console.WriteLine($"n++ * m = {resultTask1_1}, m = {m}, n = {n}");

            resultTask1_2 = m-- < n;
            Console.WriteLine($"m-- < n = {resultTask1_2}, m = {m}, n = {n}");

            resultTask1_3 = ++m > n;
            Console.WriteLine($"++m > n = {resultTask1_3}, m = {m}, n = {n}");
            #endregion

            #region Task 1.4
            double x, resultTask1_4;
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

            resultTask1_4 = Math.Cos(Math.Atan(x));
            Console.WriteLine($"y = {resultTask1_4}");
            #endregion
            #endregion

            #region Task2

            #endregion
        }
    }
}
