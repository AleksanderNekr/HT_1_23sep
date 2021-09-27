using System;

namespace Task3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            #region Calculate for double type

            {
                double a = 10;
                double b = 0.01;
                double subtrahend = Math.Pow(a - b, 4);
                double subtractor = Math.Pow(a, 4) + (6 * Math.Pow(a * b, 2)) + Math.Pow(b, 4);
                double numerator = subtrahend - subtractor;
                double denominator = -4 * a * b * (Math.Pow(b, 2) + Math.Pow(a, 2));
                double resultDouble = numerator / denominator;
                Console.WriteLine($"double: {resultDouble}");
            }

            #endregion Calculate for double type

            #region Calculate for float type

            {
                float a = 10;
                float b = 0.01f;
                float subtrahend = (float)Math.Pow(a - b, 4);
                float subtractor = (float)Math.Pow(a, 4) + (6 * (float)Math.Pow(a * b, 2)) + (float)Math.Pow(b, 4);
                float numerator = subtrahend - subtractor;
                float denominator = -4 * a * b * ((float)Math.Pow(b, 2) + (float)Math.Pow(a, 2));
                float resultFloat = numerator / denominator;
                Console.WriteLine($"float: {resultFloat}");
            }

            #endregion Calculate for float type

            /* Объяснение различия в ответах
             *             Приблизительный диапазон значений	   Точность
             *   float	   от ±1,5 x 10^−45 до ±3,4 x 10^38	       6–9 цифр
             *   double	  от ±5,0 × 10^−324 до ±1,7 × 10^308	  15–17 цифр
             *
             *   Таким образом, тип float имеет меньший диапазон значений и меньшее количество знаков после запятой,
             *  что делает его менее точным в сравнении с типом double
             */
        }
    }
}