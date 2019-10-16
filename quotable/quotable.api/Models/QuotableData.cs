using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace quotable.api.Models
{
    public class QuotableData
    {
        public IEnumerable<long> ID { get; set; }
        public IEnumerable<string> Quote { get; set; }
        public IEnumerable<string> Author { get; set; }
    }
}
