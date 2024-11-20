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
            bool numbersInvalid = true;
            while (numbersInvalid)
            {
                //try
                //{
                //    intsToDivide = GetUserInputs();
                //    int result = Divide(intsToDivide[0], intsToDivide[1]);
                //    Console.WriteLine($"Result: {result}");
                //}
                //catch (FormatException ex)
                //{
                //    Console.WriteLine("Numbers invalid, please try again.");
                //    DivideUserInputs();
                //}
                //catch (DivideByZeroException ex)
                //{
                //    Console.WriteLine("Denominator cannot be 0, please try again.");
                //    DivideUserInputs();
                //}
                //catch(NegativeIntegerInputException ex)
                //{
                //    Console.WriteLine(ex.Message);
                //    DivideUserInputs();
                //}
                InputResult result = GetUserInputs();
                if(!result.Success) Console.WriteLine(result.Message);
                else
                { 
                    numbersInvalid = false;
                    Console.WriteLine($"Result: {Divide(result.Result[0], result.Result[1])}");
                }

            }
        }
        private static InputResult GetUserInputs()
        {
            InputResult inputResult = new InputResult();
            try
            {

                Console.WriteLine("Please give us the division numerator:");
                int numerator = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Please give us the division denominator:");
                int denominator = Int32.Parse(Console.ReadLine());

                if (denominator == 0) { throw new DivideByZeroException("Zero cannot be divided!!!"); }

                if (denominator < 0 && numerator < 0)
                {
                    throw new NegativeIntegerInputException($"The following negative integer(s) are not allowed in this operation: {denominator} and {numerator}");
                }
                else if (denominator < 0 || numerator < 0)
                {

                    int negativeNumber = 0;
                    if (denominator < numerator) negativeNumber = denominator;
                    else negativeNumber = numerator;
                    throw new NegativeIntegerInputException($"The following negative integer(s) are not allowed in this operation: {negativeNumber}");
                }


                inputResult.Success = true;
                inputResult.Message = "Division is working!!";
                inputResult.Result[0] = numerator;
                inputResult.Result[1] = denominator;

                return inputResult;
            }
            catch (NegativeIntegerInputException ex)
            {
                inputResult.Message = ex.Message;
                inputResult.Result = null;
                return inputResult;
            }
            catch (DivideByZeroException ex)
            {
                inputResult.Message = ex.Message;
                inputResult.Result = null;
                return inputResult;
            }
            catch(FormatException ex)
            {
                inputResult.Message = ex.Message;
                inputResult.Result = null;
                return inputResult;
            }
  
        }
    }
}
