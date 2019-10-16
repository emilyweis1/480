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

            // assert
            Assert.AreEqual(("Quote: " + input), provider.getQuotes(input));
            Assert.AreEqual(input, provider.getID(input));
            Assert.AreEqual(("Author: " + input), provider.getAuthor(input));

        }
    }
}