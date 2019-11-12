using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// implements random quote provider to return quotes
    /// </summary>
    public class DefaultRandomQuoteGenerator : RandomQuoteProvider
    {
        /// <summary>
        /// this constructor takes in a string of quotes and returns those quotes 
        /// to the console
        /// </summary>
        /// <param name="quotesData"></param>
        public DefaultRandomQuoteGenerator(IEnumerable<string> quotesData)
        {
            foreach (var q in quotesData)
            {
                Console.WriteLine(q);
            }
        }

        /// <summary>
        /// this constructor takes in a long of the ID for the quote and returns 
        /// the author
        /// </summary>
        /// <param name="numAuths"></param>
        /// <returns></returns>
        public IEnumerable<string> getAuthor(long numAuths)
        {
            string msg = ("get " + numAuths + " authors");
            yield return msg;
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

        /// <summary>
        /// this constructor takes in a long of the ID for the quote
        /// and returns the quote
        /// </summary>
        /// <param name="numQuotes"></param>
        /// <returns></returns>
        public IEnumerable<string> getQuotes(long numQuotes)
        {
            string msg = ("get " + numQuotes + " quotes");
            yield return msg;
        }
    }
}
