using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// implements random quote provider to return quotes
    /// </summary>
    public class DatabaseRandomQuoteProvider : RandomQuoteProvider
    {

        IEnumerable<string> RandomQuoteProvider.getQuotes(long numQuotes)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// this constructor takes in a long of the ID for the quote 
        /// and returns the quote ID
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public IEnumerable<long> getID(long num)
        {
            long ID = num;
            yield return ID;
        }

        IEnumerable<string> RandomQuoteProvider.getAuthor(long numAuthors)
        {
            throw new NotImplementedException();
        }
    }
}
