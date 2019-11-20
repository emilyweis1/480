using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotable.api.Models
{
    /// <summary>
    /// Model for a quote
    /// </summary>
    public class Quote
    {
        /// <summary>
        /// The title of the quote
        /// </summary>
        public string Body { get; set; }
    }
}
