namespace FizzBuzz.Tests
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
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

        [TestCase]
        public void FindValueThrows()
        {
            Assert.Throws<ArgumentException>(() => _sut.Find(0));
        }

        [TestCase]
        public void SampleOfGeneratorIsCorrect()
        {
            var expected = new List<string>
            {
                "1",
                "2",
                "Fizz",
                "4",
                "Buzz",
                "Fizz",
                "7",
                "8",
                "Fizz",
                "Buzz",
                "11",
                "Fizz",
                "13",
                "14",
                "FizzBuzz"
            };
            Assert.That(_sut.Generate().Take(expected.Count), Is.EquivalentTo(expected));
        }
    }
}
