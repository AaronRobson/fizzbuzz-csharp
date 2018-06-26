namespace FizzBuzz
{
    using System;
    using System.Linq;
    using FizzBuzz.Library;

    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzz = new FizzBuzzCalc();
            fizzBuzz.Generate().Take(100).ToList().ForEach(x => Console.WriteLine(x));
            Console.ReadKey();
        }
    }
}
