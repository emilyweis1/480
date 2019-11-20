using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quotable.core
{
    /// <summary>
	/// A quote in the system.
	/// </summary>
	public sealed class Quote
    {
        /// <summary>
        /// The unique identifier for the quote.
        /// </summary>

        public long Id { get; set; }

        /// <summary>
        /// The body of the quote.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// The collection of authors of the quote
        /// </summary>
        public IEnumerable<Author> Authors => from x in QuoteAuthor select x.Author;

        /// <summary>
        /// The relation of quote to author
        /// </summary>
        public ICollection<QuoteAuthor> QuoteAuthor { get; set; } = new List<QuoteAuthor>();
    }
}
