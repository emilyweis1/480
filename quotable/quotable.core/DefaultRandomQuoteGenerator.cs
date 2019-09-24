using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    public class DefaultRandomQuoteGenerator : RandomQuoteProvider
    {
        public DefaultRandomQuoteGenerator(IEnumerable<string> quotesData)
        {
            Console.WriteLine("constructor");
        }

        public IEnumerable<string> getQuotes(long numQuotes)
        {
            throw new NotImplementedException();
        }
    }
}
