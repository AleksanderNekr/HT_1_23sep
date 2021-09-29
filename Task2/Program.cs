using System;

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

            // Ввод координаты x
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

            // Ввод координаты y
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

            // Проверка на принадлежность к области
            var isInArea = x >= 0 && y >= -7 && x <= 5 && x + y <= 5;

            // Вывод принадлежности
            Console.WriteLine(isInArea);
        }
    }
}