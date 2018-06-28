namespace FizzBuzz.Library.Interfaces
{
    using System.Collections.Generic;

    public interface IFizzBuzzCalc
    {
        string Find(int value);

        IEnumerable<string> Generate();
    }
}
