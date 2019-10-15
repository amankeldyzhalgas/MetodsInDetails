using System;
using System.Linq;

namespace Greatest_Common_Divisor
{
    public class Program
    {
        public static int GetGCD(int[] array)
        {
            int i = array.Min();
            for (; i < array.Length; i++)
            {
                bool reminderIsZero = true;
                for (int j = 0; j < array.Length; j++)
                    reminderIsZero &= array[j] % i == 0;
                if (reminderIsZero) break;
            }
            return i;
        }


        private static void Swap(ref int left, ref int right)
        {
            var temp = right;
            right = left % right;
            left = temp;
        }
    }
}
