using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_6
{
    class MathOperations
    {
        public static int FindMaxElement(double[] numbers)
        {
            var maxElementIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (Math.Abs(numbers[i]) > Math.Abs(numbers[maxElementIndex]))
                {
                    maxElementIndex = i;
                }
            }
            return maxElementIndex;
        } 

        public static double FindSum(double[] numbers, int index)
        {
            double sum = 0;
            if (index == -1)
            {
                return 0;
            }
            for (int i = index + 1; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            return sum;
        }

        public static int FindFirstPositiveElement(double[] numbers)
        {
            int index = -1;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > 0)
                {
                    index = i;
                    return index;
                }
            }
            return index;
        }
    }
}
