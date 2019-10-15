using System;
using System.Runtime.InteropServices;
using System.Text;

namespace Double_Extended
{
    [StructLayout(LayoutKind.Explicit)]
    struct DoubleToLong
    {
        [FieldOffset(0)]
        private double number;
        [FieldOffset(0)]
        private long longNumber;

        public DoubleToLong(double number) : this()
        {
            this.number = number;
        }

        public long getLong
        {
            get { return longNumber; }
        }
    }

    public static class Program
    {
        public static string Convert(this double number)
        {
            DoubleToLong doubleToLong = new DoubleToLong(number);
            long longNumber = doubleToLong.getLong;

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
