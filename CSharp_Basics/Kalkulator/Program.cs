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

            int parsedNumberOne = GetValueFromUser("Wprowadź liczbę a: ");
            int parsedNumberTwo = GetValueFromUser("Wprowadź liczbę b: ");

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
                case "x":
                case "*":
                    result = Multiply(parsedNumberOne, parsedNumberTwo);
                    break;
                case "/":
                    if (parsedNumberTwo != 0)
                    {
                        result = Divide(parsedNumberOne, parsedNumberTwo);
                        break;
                    }
                    else
                        Console.WriteLine("Nie dziel przez zero!");
                        break;                   
                default:
                    Console.WriteLine("Podaj poprawny znak!");
                    break;
            }

            Console.WriteLine($"Wynik działania to: {result}");
            Console.WriteLine("Kliknij dowolny przycisk, aby zakończyć...");
            Console.ReadKey();

        }

        public static int GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            string number = Console.ReadLine();
            int parsedNumber = 0;
            if (!int.TryParse(number, out parsedNumber))
            {
                Console.WriteLine($"Nie znana wartość, używamy wartości domyślnej {parsedNumber}");
            }
            return parsedNumber;
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
