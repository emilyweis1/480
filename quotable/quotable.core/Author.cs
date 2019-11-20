using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
	/// The author of a quote.
	/// </summary>
	public sealed class Author
    {
        /// <summary>
        /// The unique identifier for the author.
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// The first name of the author.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name fo the author
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// The relation of quote to author
        /// </summary>
        public ICollection<QuoteAuthor> QuoteAuthor { get; set; }
    }
}
