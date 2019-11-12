using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotable.api.Models
{
    /// <summary>
    /// Class to instantiate ID, Quote, and Author
    /// </summary>
    public class QuotableData
    {
        /// <summary>
        /// instnantiate ID of type long
        /// </summary>
        public IEnumerable<long> ID { get; set; }
        /// <summary>
        /// instnantiate Quote of type string
        /// </summary>
        public IEnumerable<string> Quote { get; set; }
        /// <summary>
        /// instnantiate Author of type string
        /// </summary>
        public IEnumerable<string> Author { get; set; }
    }
}
