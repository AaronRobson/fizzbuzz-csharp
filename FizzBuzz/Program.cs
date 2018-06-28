namespace FizzBuzz
{
    using System;
    using System.Linq;
    using FizzBuzz.Library;
    using FizzBuzz.Library.Interfaces;

    class Program
    {
        private static IFizzBuzzCalc fizzBuzz;

        static void Main(string[] args)
        {
            fizzBuzz = new FizzBuzzCalc();
            fizzBuzz.Generate().Take(100).ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
