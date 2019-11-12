using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;

namespace Tests
{
    /// <summary>
    /// class to hold all tests for quoteController
    /// </summary>
    public class Tests
    {
        /// <summary>
        /// initialize setup for quotable/tests
        /// </summary>
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// test to ensure SimpleRandomQuoteProvider is returning the correct and expected value
        /// </summary>
        [Test]
        public void Test_Get_Success()
        {
            var provider = new SimpleRandomQuoteProvider();
            var controller = new QuoteController(provider);

            var actual = controller.Get(5);

            Assert.That(actual.Value.ID, Is.EqualTo(5));
            Assert.That(actual.Value.Quote, Is.EquivalentTo(new string ("get " + actual + " quotes")));
            Assert.That(actual.Value.Author, Is.EquivalentTo(new string("get " + actual + " authors")));
        }
    }
}