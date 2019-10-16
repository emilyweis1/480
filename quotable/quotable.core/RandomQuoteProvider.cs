using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    public interface RandomQuoteProvider
    {
        /// <summary>
        /// Method of type: IEnumerable<string> called getQuotes()
        /// which takes in a long: number of quotes as a perameter
        /// </summary>
        /// <param name="numQuotes"></param>
        /// <returns></returns>
        IEnumerable<string> getQuotes(long numQuotes);

        IEnumerable<long> getID(long numQuotes);

        IEnumerable<string> getAuthor(long numQuotes);
    }
}
