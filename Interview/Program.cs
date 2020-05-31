using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    class Program
    {
        public static int CalculateTheFactorialOfGivenNumber(int number)
        {
            if (number == 1)
                return 1;

            return number * CalculateTheFactorialOfGivenNumber(number - 1);
        }

        public static void SwapWithoutCreatingThirdVariable(int a, int b)
        {
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"After swapping => a is {a} : b is {b}");
        }

        public static void PrintInReversedOrder(double numbToReverse)
        {
            char[] reversedDoubleAsCharArray = numbToReverse.ToString().Reverse().ToArray();

            string reversedDoubleAsString = new string(reversedDoubleAsCharArray);

            Console.WriteLine(reversedDoubleAsString);
        }

        public static void FindFibonacciSeriesOfGivenNumber(int number)
        {
            int a = 0, b = 1, c = 0;
            List<int> collectedNumbers = new List<int>() { 0 };

            for (int i = 2; i < number; i++)
            {
                c = a + b;
                a = b;
                b = c;

                collectedNumbers.Add(c);
            }

            PrintGivenArray(collectedNumbers);
        }

        public static void PrintGivenArray(List<int> numbers)
        {
            Console.WriteLine("Fibonacci numbers of given number . . .");

            foreach (var number in numbers)
            {
                Console.Write(number + " ");
            }
        }

        static void Main(string[] args)
        {
            int numberToCalculateFactorial = 5;
            Console.WriteLine($"Factorial of the {numberToCalculateFactorial} is " +
                $"{CalculateTheFactorialOfGivenNumber(numberToCalculateFactorial)}");

            SwapWithoutCreatingThirdVariable(10, 15);


            PrintInReversedOrder(123.3);

            FindFibonacciSeriesOfGivenNumber(15);

            Console.ReadKey();
        }
    }
}
