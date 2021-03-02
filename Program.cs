using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzzGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Witaj w grze FizzBuzzGame.\n");
            var inputDigit = 0;
            while (true)
            {
                Console.WriteLine("Aby zagrać podaj liczbę.\nJeśli chcesz zakończyć grę wciśniej 'Q'.");
                inputDigit = GetUserDigit();

                var fizzBuzz = new FizzBuzz();
                Console.WriteLine(fizzBuzz.SetResult(inputDigit) + "\n");
            }
        }

        private static int GetUserDigit()
        {
            while (true)
            {
                var val = Console.ReadLine();
                if (val.ToUpper() == "Q") Environment.Exit(0);

                if (!int.TryParse(val, out int userDigit))
                {
                    Console.WriteLine("\nPrzykro mi. Wprowadzone przez Ciebie dane nie są poprawne. \nPodaj jeszcze raz liczbę całkowitą nie większą jak 4294967295.");
                    continue;
                }
                return userDigit;
            }
        }
    }
}
