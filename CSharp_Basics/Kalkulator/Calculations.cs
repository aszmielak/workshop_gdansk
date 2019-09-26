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
        /// Data saving math method using custom dataMath object
        /// </summary>
        /// <param name="mathData"></param>
        /// <returns></returns>
        public static double GetResultValue(MathData mathData)
        {
            double result = 0;

            switch (mathData.Operation)
            {
                case "+":
                    result = Add(mathData.FirstValue, mathData.SecondValue);
                    break;
                case "-":
                    result = Subtract(mathData.FirstValue, mathData.SecondValue);
                    break;
                case "x":
                case "*":
                    result = Multiply(mathData.FirstValue, mathData.SecondValue);
                    break;
                case "/":
                    if (mathData.SecondValue != 0)
                    {
                        result = Divide(mathData.FirstValue, mathData.SecondValue);
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
