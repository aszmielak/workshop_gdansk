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
            while (true)
            {
                MathData mathData = ValueInterface.GetAllValuesFromCustomer();

                double finalResult = Calculations.GetResultValue(mathData);

                Console.WriteLine($"Wynik działania to: {finalResult}");
                Console.WriteLine("Kliknij przycisk Q, aby zakończyć...");
                string closingOperation = Console.ReadLine();

            }
        }
    }
}
