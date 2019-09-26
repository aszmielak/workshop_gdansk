using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public static class ValueInterface
    {
        public static void Quit()
        {
            Console.WriteLine("Zamykam aplikację! quit!");
            Console.ReadKey();
            Environment.Exit(0);
        }

        

        public static MathData GetAllValuesFromCustomer()
        {
            int firstValue = GetValueFromUser("Wprowadź liczbę a: ");
            int secondValue = GetValueFromUser("Wprowadź liczbę b: ");
            string operation = GetOperation();

            return new MathData(firstValue, secondValue, operation);
        }

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
                    Quit();
                    return 0;
                }

                parsed = int.TryParse(valueFromUser, out parsedValueFromUser);
                if (!parsed)
                {
                    message = $"Podana wartość - {valueFromUser} - jest niepoprawna, podaj poprawną:";
                }
            }

            return parsedValueFromUser;
        }

        public static string GetOperation()
        {
            Console.WriteLine("Podaj operację: ");
            string operation = Console.ReadLine();
            if (operation == "q")
            {
                Quit();
                return string.Empty;
            }

            return operation;
        }
    }
}
