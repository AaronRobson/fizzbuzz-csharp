namespace FizzBuzz.Tests
{
    using NUnit.Framework;
    using FizzBuzz.Library;

    [TestFixture]
    public class WhenProducingFizzBuzzValues
    {
        private FizzBuzzCalc _sut;

        [SetUp]
        public void Given()
        {
            _sut = new FizzBuzzCalc();
        }

        [TestCase(1, ExpectedResult = "1", TestName = "Simple")]
        [TestCase(3, ExpectedResult = "Fizz", TestName = "Fizz")]
        [TestCase(5, ExpectedResult = "Buzz", TestName = "Buzz")]
        [TestCase(15, ExpectedResult = "FizzBuzz", TestName = "FizzBuzz")]
        public string FindValue(int value)
        {
            return _sut.Find(value);
        }
    }
}
