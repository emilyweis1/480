using NUnit.Framework;
using quotable.core;

namespace Tests
{
    /// <summary>
    /// Class to hold all testing for quotbale
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// set's up quotable on startup
        /// </summary>
        [OneTimeSetUp]
        public void OneTimeSetup()
        {
        }

        /// <summary>
        /// method to setup quotable
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Tests the providers with a set input to make sure output is as expected
        /// </summary>
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