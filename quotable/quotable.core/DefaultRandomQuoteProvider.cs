using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
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

        public IEnumerable<string> getAuthor(long numAuths)
        {
            string msg = ("get " + numAuths + " authors");
            yield return msg;
        }

        public IEnumerable<long> getID(long num)
        {
            long ID = num;
            yield return ID;
        }

        public IEnumerable<string> getQuotes(long numQuotes)
        {
            string msg = ("get " + numQuotes + " quotes");
            yield return msg;
        }
    }
}
