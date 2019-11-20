using System;
using System.Collections.Generic;
using System.Text;

namespace quotable.core
{
    /// <summary>
    /// Represents the many-to-many relation between quotes and authors
    /// </summary>
    public class QuoteAuthor
    {
        /// <summary>
        /// The ID of the Quote related to the author.
        /// </summary>
        public long QuoteId { get; set; }
        /// <summary>
        /// The Quote related to the author.
        /// </summary>
        public Quote Quote { get; set; }

        /// <summary>
        /// The ID of the author related to the Quote.
        /// </summary>
        public long AuthorId { get; set; }
        /// <summary>
        /// The author related to the Quote.
        /// </summary>
        public Author Author { get; set; }
    }
}
