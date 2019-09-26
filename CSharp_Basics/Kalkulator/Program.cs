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
        static bool quit = false;

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
            while (!quit)
            {
                Console.WriteLine("Calc");
                int parsedNumberOne = GetValueFromUser("Wprowadź liczbę a: ");
                if (quit)
                {
                    Console.WriteLine("Zamykam aplikację.");
                    Console.ReadKey();
                    return;
                }

                int parsedNumberTwo = GetValueFromUser("Wprowadź liczbę b: ");
                if (quit)
                {
                    Console.WriteLine("Zamykam aplikację.");
                    Console.ReadKey();
                    return;
                }

                Console.WriteLine("Wprowadź symbol: ");
                string operation = Console.ReadLine();
                double finalResult = Calculations.GetResultValue(parsedNumberOne, parsedNumberTwo, operation);

                Console.WriteLine($"Wynik działania to: {finalResult}");
                Console.WriteLine("Kliknij przycisk Q, aby zakończyć...");
                string closingOperation = Console.ReadLine();

                if (closingOperation == "q") 
                {
                    Console.WriteLine("Zamykam aplikację.");
                    ////Console.ReadKey();
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
            bool parsed = false;
            int parsedValueFromUser = 0;
            while (!parsed)
            {
                Console.WriteLine(message);
                string valueFromUser = Console.ReadLine();
                if (valueFromUser == "q")
                {
                    quit = true;
                    return 0;
                }

                parsed = int.TryParse(valueFromUser, out parsedValueFromUser);
                if (!parsed)
                {
                    message = ($"Nie znana wartość, użyj poprawnej wartości, a nie {parsedValueFromUser}");
                }       
            }

            return parsedValueFromUser;
        }
    }
}
