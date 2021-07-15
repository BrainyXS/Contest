using System;
using System.Collections.Generic;
using System.Linq;
using FizzBuzz.Strategies;

namespace FizzBuzz
{
    public class FizzBuzzManager
    {
        private List<IFizzBuzzPattern> _pattern;

        public FizzBuzzManager()
        {
            _pattern = new List<IFizzBuzzPattern>
            {
                new DefaultPattern(),
                new FizzPattern(),
                new BuzzPattern(),
                new FizzBuzzPattern()
            };
        }

        private const int MAX_TRIES = 3;

        public int ReadTimesOrDie()
        {
            Console.WriteLine("Bitte die Obergrenze eingeben.");
            for (var i = 0; i < MAX_TRIES; i++)
            {
                var input = Console.ReadLine();
                if (int.TryParse(input, out var converted))
                {
                    Console.WriteLine("Eingabe Erfolgreich! Starte Programm");
                    return converted;
                }

                Console.WriteLine("Eingabe ungültig!\nErneut versuchen");
            }

            Console.WriteLine("Zu viele fehlgeschlagene versuche.\nBeende Programm");
            throw new Exception("Keine Versuche mehr übrig");
        }

        public void ExecuteFizzButt(int times)
        {
            for (var i = 1; i <= times; i++)
            {
                Console.WriteLine(_pattern.Single(pattern => pattern.IsResponsible(i)).Execute(i));
            }
        }
    }
}