using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            //for(int j=0;j<100;j++)
            //{
            //    Console.WriteLine(j);
            //}
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("Calc");

                int parsedNumberOne = GetValueFromUser("Wprowadź liczbę a: ");
                int parsedNumberTwo = GetValueFromUser("Wprowadź liczbę b: ");
                Console.WriteLine("Wprowadź symbol: ");
                string operation = Console.ReadLine();
                double finalResult = GetResultValue(parsedNumberOne, parsedNumberTwo, operation);

                Console.WriteLine($"Wynik działania to: {finalResult}");
                Console.WriteLine("Kliknij przycisk Q, aby zakończyć...");
                string closingOperation = Console.ReadLine();

                if (closingOperation == "q") 
                {
                    Console.WriteLine("Zamykam aplikację.");
                    //Console.ReadKey();
                    Thread.Sleep(1500);
                    return;
                }
            }
        }

        /// <summary>
        /// Get both values from user
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static int GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            string valueFromUser = Console.ReadLine();
            int parsedValueFromUser = 0;
            if (!int.TryParse(valueFromUser, out parsedValueFromUser))
            {
                Console.WriteLine($"Nie znana wartość, używamy wartości domyślnej {parsedValueFromUser}");
            }

            return parsedValueFromUser;
        }

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
