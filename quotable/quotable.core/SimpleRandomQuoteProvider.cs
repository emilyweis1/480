using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// implements random quote provider and returns quote per method based on input
    /// </summary>
   public class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        /// <summary>
        /// hardcoded to return the author 
        /// takes in a value to determine author
        /// for the quote
        /// </summary>
        /// <param name="numAuths"></param>
        /// <returns></returns>
        public IEnumerable<string> getAuthor(long numAuths)
        {

            String authors = ("Author: " + numAuths);
           

            yield return authors;
        }

        /// <summary>
        /// hardcoded to return the ID of the quote you pass
        /// in as a perameter
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public IEnumerable<long> getID(long i)
        {
            long ID = i;

            yield return ID;
        }

        /// <summary>
        /// hardcoded to return the numQuotes 
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
