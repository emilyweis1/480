using NUnit.Framework;
using quotable.core;

namespace Tests
{
    public class Tests
    {
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
        }

        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test()
        {
            // arrange
            var provider = new SimpleRandomQuoteProvider();
            long input = 5;
            long expected = 5;

            // act
            var actual = provider.getQuotes(input);

            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}