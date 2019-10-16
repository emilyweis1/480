using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using quotable.api.Models;
using quotable.core;
using Microsoft.AspNetCore.Mvc;


namespace quotable.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private RandomQuoteProvider Provider { get; }

        public QuoteController(RandomQuoteProvider provider)
        {
            Provider = provider;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

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

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }

    [Route("api/[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
        private RandomQuoteProvider Provider { get; }

        public RandomController(RandomQuoteProvider provider)
        {
            Provider = provider;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

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

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
