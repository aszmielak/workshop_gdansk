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
            while (!ValueInterface.Quit)
            {
                Console.WriteLine("Calc");
                int parsedNumberOne = ValueInterface.GetValueFromUser("Wprowadź liczbę a: ");
                if (ValueInterface.Quit)
                {
                    Console.WriteLine("Zamykam aplikację.");
                    Console.ReadKey();
                    return;
                }

                int parsedNumberTwo = ValueInterface.GetValueFromUser("Wprowadź liczbę b: ");
                if (ValueInterface.Quit)
                {
                    Console.WriteLine("Zamykam aplikację.");
                    Console.ReadKey();
                    return;
                }

                string operation = ValueInterface.GetOperation();
                if (ValueInterface.Quit)
                {
                    Console.WriteLine("Zamykam aplikację.");
                    ////Console.ReadKey();
                    Thread.Sleep(1500);
                    return;
                }
                double finalResult = Calculations.GetResultValue(parsedNumberOne, parsedNumberTwo, operation);

                Console.WriteLine($"Wynik działania to: {finalResult}");
                Console.WriteLine("Kliknij przycisk Q, aby zakończyć...");
                string closingOperation = Console.ReadLine();

                if (ValueInterface.Quit) 
                {
                    Console.WriteLine("Zamykam aplikację.");
                    ////Console.ReadKey();
                    Thread.Sleep(1500);
                    return;
                }
            }
        }
    }
}
