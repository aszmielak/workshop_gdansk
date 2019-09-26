using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public static class Calculations
    {
        /// <summary>
        /// Method doing all the math
        /// </summary>
        /// <param name="numberOne"></param>
        /// <param name="numberTwo"></param>
        /// <param name="operation"></param>
        /// <returns></returns>
        public static double GetResultValue(int numberOne, int numberTwo, string operation)
        {
            double result = 0;

            switch (operation)
            {
                case "+":
                    result = Add(numberOne, numberTwo);
                    break;
                case "-":
                    result = Subtract(numberOne, numberTwo);
                    break;
                case "x":
                case "*":
                    result = Multiply(numberOne, numberTwo);
                    break;
                case "/":
                    if (numberTwo != 0)
                    {
                        result = Divide(numberOne, numberTwo);
                        break;
                    }
                    else
                        Console.WriteLine("Nie dziel przez zero!");
                    break;
                default:
                    Console.WriteLine("Podaj poprawny znak!");
                    break;
            }

            return result;
        }

        /// <summary>
        /// Adding two digits
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        private static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        /// <summary>
        /// Substracting two digits
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        private static int Subtract(int firstNumber, int secondNumber)
        {
            int sub = firstNumber - secondNumber;
            return sub;
        }

        /// <summary>
        /// Multiplying two digits
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        private static int Multiply(int firstNumber, int secondNumber)
        {
            int multi = firstNumber * secondNumber;
            return multi;
        }

        /// <summary>
        /// Dividing two digits
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        private static double Divide(double firstNumber, double secondNumber)
        {
            double div = firstNumber / secondNumber;
            return div;
        }
    }
}
