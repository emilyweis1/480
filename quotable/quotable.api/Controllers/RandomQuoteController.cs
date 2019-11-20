using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quotable.api.Models;
using quotable.core;
using Microsoft.AspNetCore.Mvc;
using Quote = quotable.api.Models.Quote;

namespace quotable.api.Controllers
{
    /// <summary>
    /// controller for random quote provider
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class RandomQuoteController : ControllerBase
    {
        private RandomQuoteProvider Provider { get; }

        /// <summary>
        /// assigns global provider to passed in provider
        /// </summary>
        /// <param name="provider"></param>
        public RandomQuoteController(RandomQuoteProvider provider)
        {
            Provider = provider;
        }

        /// <summary>
        /// returns array of strings
        /// </summary>
        /// <returns></returns>
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// gets id, quote and author with provided id
        /// sets quotable data var
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<QuotableData> Get(int id)
        {
            var data = new QuotableData();
            data.ID = Provider.getID(id);
            data.Quote = Provider.getQuotes(id);
            data.Author = Provider.getAuthor(id);

            return data;
        }

        /// <summary>
        /// unimplemented method to post value
        /// </summary>
        /// <param name="value"></param>
        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        /// <summary>
        /// unimplemented method that puts based on id and value
        /// </summary>
        /// <param name="id"></param>
        /// <param name="value"></param>
        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        /// <summary>
        /// unimplemented method that delets based on id
        /// </summary>
        /// <param name="id"></param>
        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
