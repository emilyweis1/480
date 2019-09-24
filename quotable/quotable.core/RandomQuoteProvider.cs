using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    interface RandomQuoteProvider
    {
        IEnumerable<string> getQuotes(long numQuotes);
    }
}
