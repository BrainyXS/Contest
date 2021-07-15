using System;
using Generals;

namespace FizzBuzz
{
    class Startup
    {
        static void Main(string[] args)
        {
            IntroGenerator.PrintIntro("FizzBuzz");
            var manager = new FizzBuzzManager();
            var times = manager.ReadTimesOrDie();
            Console.WriteLine("\n\n");
            manager.ExecuteFizzButt(times);
        }
    }
}