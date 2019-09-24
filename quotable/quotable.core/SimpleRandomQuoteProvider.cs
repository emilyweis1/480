using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        public IEnumerable<string> getQuotes(long numQuotes)
        {
            String[] quotes;
            quotes = new string[3] { "Quote 1", "Quote 2", "Quote 3" };

            return quotes;
        }
    }
}
