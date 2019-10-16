using NUnit.Framework;
using quotable.api.Controllers;
using quotable.core;

namespace Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

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