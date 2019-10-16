using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
   public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        public IEnumerable<string> getAuthor(long numAuths)
        {

            String authors = ("Author: " + numAuths);
           

            yield return authors;
        }

        public IEnumerable<long> getID(long i)
        {
            long ID = i;

            yield return ID;
        }

        /// <summary>
        /// hardcoded to return the array of numQuotes size
        /// takes in a value to determine numQuotes
        /// for how many random quotes you want to randomly create
        /// </summary>
        /// <param name="numQuotes"></param>
        /// <returns> returns the array of numQuotes </returns>
        public IEnumerable<string> getQuotes(long numQuotes)
        {

            String quotes = ("Quote: " + numQuotes );

            yield return quotes;
        }
    }
}
