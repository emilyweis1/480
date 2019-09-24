using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    class SimpleRandomQuoteProvider : RandomQuoteProvider
    {
        /// <summary>
        /// hardcoded to return the array of numQuotes size
        /// takes in a value to determine numQuotes
        /// for how many random quotes you want to randomly create
        /// </summary>
        /// <param name="numQuotes"></param>
        /// <returns> returns the array of numQuotes </returns>
        public IEnumerable<string> getQuotes(long numQuotes)
        {
            String[] quotes = new string[numQuotes];

            for(int i = 0; i<quotes.Length; i++)
            {
                quotes[i] = ("Quote: " + i );
            }

            return quotes;
        }
    }
}
