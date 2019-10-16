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


        /// <summary>
        /// Method of type: IEnumerable<long> called getID()
        /// which takes in a long: number of ID as a perameter
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        IEnumerable<long> getID(long id);

        /// <summary>
        /// Method of type: IEnumerable<string> called getAuthor()
        /// which takes in a long: number of authors as a perameter
        /// </summary>
        /// <param name="numAuthors"></param>
        /// <returns></returns>
        IEnumerable<string> getAuthor(long numAuthors);
    }
}
