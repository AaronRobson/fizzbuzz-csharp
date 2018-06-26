namespace FizzBuzz.Library
{
    using System.Collections.Generic;

    public class FizzBuzzCalc
    {
        public string Find(int value)
        {
            var wordedValue = (value % 3 == 0 ? "Fizz" : string.Empty) +
                (value % 5 == 0 ? "Buzz" : string.Empty);

            if (wordedValue == string.Empty)
            {
                return value.ToString();
            }
            return wordedValue;
        }

        public IEnumerable<string> Generate()
        {
            var value = 1;
            while (true)
            {
                yield return Find(value);
                value += 1;
            }
        }
    }
}
