using System;
using System.Diagnostics;
using System.Linq;

namespace Greatest_Common_Divisor
{
    public class Program
    {
        #region EuclidGCE
        /// <summary>
        /// Метод выполнять вычисления НОД по алгоритму Евклида для двух целых чисел 
        /// </summary>
        /// <param name="first">
        /// Первое число
        /// </param>
        /// <param name="second">
        /// Второе число
        /// </param>
        /// <returns>
        /// Наибольший общий делитель
        /// </returns>
        private static int GCDEuclid(int first, int second)
        {
            if (first == 0 && second == 0)
            {
                throw new ArgumentException("Числа не могут быть равны нулю.");
            }

            if (first == second)
            {
                return first;
            }

            if (first == 0)
            {
                return second;
            }

            if (second == 0)
            {
                return first;
            }

            first = Math.Abs(first);
            second = Math.Abs(second);
            while (first != second)
            {
                if (first > second)
                {
                    first -= second;
                }
                else
                {
                    second -= first;
                }
            }

            return first;
        }
        /// <summary>
        /// Метод выполнять вычисления НОД по алгоритму Евклида для двух целых чисел 
        /// </summary>
        /// <param name="first">
        /// Первое число
        /// </param>
        /// <param name="second">
        /// Второе число
        /// </param>
        /// <returns>
        /// Наибольший общий делитель
        /// </returns>
        private static int GCDEuclid(Func<int, int, int> function, int first, int second) => function(first, second);
        /// <summary>
        /// Метод выполнять вычисления НОД по алгоритму Евклида для трех целых чисел 
        /// </summary>
        /// <param name="first">
        /// Первое число
        /// </param>
        /// <param name="second">
        /// Второе число
        /// </param>
        /// <returns>
        /// Наибольший общий делитель
        /// </returns>
        private static int GCDEuclid(Func<int, int, int> function, int first, int second, int third) => function(function(first, second), third);
        /// <summary>
        /// Метод выполнять вычисления НОД по алгоритму Евклида для четырех и более целых чисел 
        /// </summary>
        /// <param name="array">
        /// Числа
        /// </param>
        /// <returns>
        /// Наибольший общий делитель
        /// </returns>
        private static int GCDEuclid(Func<int, int, int> function, params int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException("Массив не должен быть null");
            }
            if (!array.Any())
            {
                throw new ArgumentException("Массив не может быть пустым");
            }

            if (array.Length == 1 || array.Length == 0)
            {
                throw new ArgumentException("Для нахождении нуэен 2 и более чисел");
            }

            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result = function(result, array[i]);
            }

            return result;
        }
        #endregion

        #region EuclidGCEWithTimer
        public static int FindGCDEuclid(int first, int second) => GCDEuclid(GCDEuclid, first, second);
        public static int FindGCDEuclid(int first, int second, int third) => GCDEuclid(GCDEuclid, first, second, third);
        public static int FindGCDEuclid(int[] array) => GCDEuclid(GCDEuclid, array);

        public static int FindGCDEuclid(int first, int second, out long timer)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = GCDEuclid(GCDEuclid, first, second);
            timer = sw.ElapsedTicks;
            sw.Stop();
            return result;
        }
        public static int FindGCDEuclid(int first, int second, int third, out long timer)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = GCDEuclid(GCDEuclid, first, second, third);
            timer = sw.ElapsedTicks;
            sw.Stop();
            return result;
        }
        public static int FindGCDEuclid(int[] array, out long timer)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            int result = GCDEuclid(GCDEuclid, array);
            timer = sw.ElapsedTicks;
            sw.Stop();
            return result;
        }
        #endregion

        #region GCDStein
        /// <summary>
        /// Метод выполнять вычисления НОД по алгоритму Стейна для двух целых чисел 
        /// </summary>
        /// <param name="first">
        /// Первое число
        /// </param>
        /// <param name="second">
        /// Второе число
        /// </param>
        /// <returns>
        /// Наибольший общий делитель
        /// </returns>
        private static int GCDBinary(int first, int second)
        {
            if (first == 0 && second == 0)
            {
                throw new ArgumentException("Числа не могут быть равны нулю.");
            }
            if (first == second)
            {
                return first;
            }
            if (first == 0)
            {
                return second;
            }
            if (second == 0)
            {
                return first;
            }
            first = Math.Abs(first);
            second = Math.Abs(second);
            if ((~first & 1) != 0)
            {
                if ((second & 1) != 0)
                {
                    return GCDBinary(first >> 1, second);
                }
                else
                {
                    return GCDBinary(first >> 1, second >> 1) << 1;
                }
            }
            if ((~second & 1) != 0)
            {
                return GCDBinary(first, second >> 1);
            }
            if (first > second)
            {
                return GCDBinary((first - second) >> 1, second);
            }
            return GCDBinary((second - first) >> 1, first);
        }
        /// <summary>
        /// Метод выполнять вычисления НОД по алгоритму Стейна для двух целых чисел 
        /// </summary>
        /// <param name="first">
        /// Первое число
        /// </param>
        /// <param name="second">
        /// Второе число
        /// </param>
        /// <returns>
        /// Наибольший общий делитель
        /// </returns>
        private static int GCDBinary(Func<int, int, int> function, int first, int second) => function(first, second);
        /// <summary>
        /// Метод выполнять вычисления НОД по алгоритму Стейна для трех целых чисел 
        /// </summary>
        /// <param name="first">
        /// Первое число
        /// </param>
        /// <param name="second">
        /// Второе число
        /// </param>
        /// <returns>
        /// Наибольший общий делитель
        /// </returns>
        private static int GCDBinary(Func<int, int, int> function, int first, int second, int third) => function(function(first, second), third);
        /// <summary>
        /// Метод выполнять вычисления НОД по алгоритму Стейна для четырех и более целых чисел 
        /// </summary>
        /// <param name="array">
        /// Числа
        /// </param>
        /// <returns>
        /// Наибольший общий делитель
        /// </returns>
        private static int GCDBinary(Func<int, int, int> function, params int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException("Массив не должен быть null");
            }
            if (!array.Any())
            {
                throw new ArgumentException("Массив не может быть пустым");
            }

            if (array.Length == 1 || array.Length == 0)
            {
                throw new ArgumentException("Для нахождении нуэен 2 и более чисел");
            }
            int result = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                result = function(result, array[i]);
            }
            return result;
        }

        public static int FindGCDStein(int first, int second) => GCDBinary(GCDBinary, first, second);
        public static int FindGCDStein(int first, int second, int third) => GCDBinary(GCDBinary, first, second, third);
        public static int FindGCDStein(int[] array) => GCDBinary(GCDBinary, array);

        #endregion
    }
}
