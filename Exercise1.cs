using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Exercise1
    {
        public static int Divide(int a, int b)
        {
            return a / b;
        }
        public static void DivideUserInputs()
        {
            int[] intsToDivide = new int[2];
            bool numbersInvalid = true;
            while (numbersInvalid)
            {
                try
                {
                    intsToDivide = GetUserInputs();
                    int result = Divide(intsToDivide[0], intsToDivide[1]);
                    Console.WriteLine($"Result: {result}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Numbers invalid, please try again.");
                    DivideUserInputs();
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine("Denominator cannot be 0, please try again.");
                    DivideUserInputs();
                }
                numbersInvalid = false;
            }
        }
        private static int[] GetUserInputs()
        {
            Console.WriteLine("Please give us the division numerator:");
            int numerator = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Please give us the division denominator:");
            int denominator = Int32.Parse(Console.ReadLine());

            int[] result = new int[] { numerator, denominator };
            return result;
        }
    }
}
