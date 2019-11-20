using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace quotable.core
{
    /// <summary>
	/// A document in the system.
	/// </summary>
	public sealed class Document
    {
        /// <summary>
        /// The unique identifier for the document.
        /// </summary>

        public long Id { get; set; }

        /// <summary>
        /// The title of the document.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The collection of authors of the document
        /// </summary>
        public IEnumerable<Author> Authors => from x in DocumentAuthor select x.Author;

        /// <summary>
        /// The relation of document to author
        /// </summary>
        public ICollection<DocumentAuthor> DocumentAuthor { get; set; } = new List<DocumentAuthor>();
    }
}
