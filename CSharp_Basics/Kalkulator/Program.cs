using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    /// <summary>
    /// Calculator test by Adam
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Main application
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("Calc");

            Console.WriteLine("Wprowadź liczbę a: ");
            string numberOne = Console.ReadLine();
            int parsedNumberOne = int.Parse(numberOne);

            Console.WriteLine("Wprowadź liczbę b: ");
            string numberTwo = Console.ReadLine();
            int parsedNumberTwo = int.Parse(numberTwo);

            Console.WriteLine("Wprowadź symbol: ");
            string operation = Console.ReadLine();

            double result = 0;

            switch (operation)
            {
                case "+":
                    result = Add(parsedNumberOne, parsedNumberTwo);
                    break;
                case "-":
                    result = Subtract(parsedNumberOne, parsedNumberTwo);
                    break;
                case "*":
                    result = Multiply(parsedNumberOne, parsedNumberTwo);
                    break;
                case "/":
                    result = Divide(parsedNumberOne, parsedNumberTwo);
                    break;
                default:
                    Console.WriteLine("Podaj poprawny znak!");
                    break;
            }

            //if (operation == "+")
            //{
            //    result = Add(parsedNumberOne, parsedNumberTwo);
            //}

            //else if (operation == "-")
            //{
            //    result = Subtract(parsedNumberOne, parsedNumberTwo);
            //}

            //else if (operation == "*")
            //{
            //    result = Multiply(parsedNumberOne, parsedNumberTwo);
            //}

            //else if (operation == "/")
            //{
            //    result = Divide(parsedNumberOne, parsedNumberTwo);
            //}

            //else
            //{
            //    Console.WriteLine("Podaj poprawny znak!");
            //}

            Console.WriteLine($"Wynik działania to: {result}");
            Console.WriteLine("Kliknij dowolny przycisk, aby zakończyć...");
            Console.ReadKey();

            ////Console.WriteLine("Wprowadź znak działania: ");
            ////string sign = Console.ReadLine();
            ////Console.ReadKey();
        }

        /// <summary>
        /// Adding two digits
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static int Add(int firstNumber, int secondNumber)
        {
            int sum = firstNumber + secondNumber;
            return sum;
        }

        /// <summary>
        /// substracting two digits
        /// </summary>
        /// <param name="firstNumber"></param>
        /// <param name="secondNumber"></param>
        /// <returns></returns>
        public static int Subtract(int firstNumber, int secondNumber)
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
        public static int Multiply(int firstNumber, int secondNumber)
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
        public static double Divide(double firstNumber, double secondNumber)
        {
            double div = firstNumber / secondNumber;
            return div;
        }
    }
}
