using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 10;
            double b = 0.01;
            #region Calculate for double type
            double expressionD = (Math.Pow(a - b, 4) - (Math.Pow(a, 4) + (6 * Math.Pow(a * b, 2)) + Math.Pow(b, 4))) / (-4 * a * b * (Math.Pow(b, 2) + Math.Pow(a, 2)));

            // 0,999999999999975
            Console.WriteLine($"Выражение с double типом равно: {expressionD}");
            #endregion

            #region Calculate for float type
            float expressionF = (float)expressionD;

            // 1
            Console.WriteLine($"Выражение с float типом равно: {expressionF}");
            #endregion

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
