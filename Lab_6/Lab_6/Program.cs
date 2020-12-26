using System;

namespace Lab_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a length of array: ");
            int length = CheckInput();
            double[] numbers = new double[length];
            numbers = FillArray(length);
            OutputArray(numbers);
            Console.WriteLine($"\r\nIndex of max element: {MathOperations.FindMaxElement(numbers)}");
            var index = MathOperations.FindFirstPositiveElement(numbers);
            Console.WriteLine($"Sum of elements after first positive element: {MathOperations.FindSum(numbers, index)}");
        }

        static int CheckInput()
        {
            int number;
            while (!int.TryParse(Console.ReadLine(), out number) || number < 0)
            {
                Console.WriteLine("You enter invalid data!");
            }
            return number;
        }

        static double[] FillArray(int length)
        {
            double[] numbersArray = new double[length];
            double number;
            for (int i = 0; i < length; i++)
            {
                Console.Write("Enter number for array: ");
                while (!double.TryParse(Console.ReadLine(), out number))
                {
                    Console.WriteLine("You enter invalid data! Try again: ");
                }
                numbersArray[i] = number;
            }
            return numbersArray;
        }

        static void OutputArray(double[] array)
        {
            Console.Write("Your array: ");
            foreach (double number in array)
            {
                Console.Write($"{number} ");
            }
        }
    }
}
