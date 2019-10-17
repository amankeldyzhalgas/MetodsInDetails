using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Double_Extended
{
    /// <summary>
    /// Структура DoubleToLong
    /// </summary>
    [StructLayout(LayoutKind.Explicit)]
    struct DoubleToLong
    {
        [FieldOffset(0)]
        private double number;
        [FieldOffset(0)]
        private long longNumber;
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="number">
        /// Вещественное число
        /// </param>
        public DoubleToLong(double number) : this()
        {
            this.number = number;
        }
        /// <summary>
        /// Getter longNumber
        /// </summary>
        public long getLong
        {
            get { return longNumber; }
        }
    }

    public static class Program
    {
        /// <summary>
        /// Метод реализует получения строкового представления вещественного числа в формате IEEE 754.
        /// </summary>
        /// <param name="number">
        /// Число
        /// </param>
        /// <returns>
        /// Строковоего представление вещественного числаНаибольший общий делитель
        /// </returns>
        public static string Convert(this double number)
        {
            DoubleToLong doubleToLong = new DoubleToLong(number);
            long longNumber = doubleToLong.getLong;
            long lng = (long)number;

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 64; i++)
            {
                if ((longNumber & 1) == 0)
                {
                    result.Insert(0, "0");
                }

                if ((longNumber & 1) == 1)
                {
                    result.Insert(0, "1");
                }

                longNumber = longNumber >> 1;
            }

            return result.ToString();
        }

    }
}
