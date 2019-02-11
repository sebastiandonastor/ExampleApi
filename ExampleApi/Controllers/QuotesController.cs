using ExampleApi.Data;
using ExampleApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExampleApi.Controllers
{
    public class QuotesController : ApiController
    {
        PassageDbContext _passageDbContext = new PassageDbContext();
        // GET: api/Quotes
        public IEnumerable<Quote> Get()
        {
            return _passageDbContext.Quotes.ToList();
        }

        // GET: api/Quotes/5
        public IHttpActionResult Get(int id)
        {

            var quote = _passageDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            if (quote == null) {
                return NotFound();
                    };
            return Ok(quote);
        }

        // POST: api/Quotes
        public void Post([FromBody]Quote value)
        {
            _passageDbContext.Quotes.Add(value);
            _passageDbContext.SaveChanges();
        }

        // PUT: api/Quotes/5
        public void Put(int id, [FromBody]Quote value)
        {
            var quote = _passageDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            quote.Title = value.Title;
            quote.Author = value.Author;
            quote.Content = value.Content;
            _passageDbContext.SaveChanges();
        }

        // DELETE: api/Quotes/5
        public void Delete(int id)
        {
            var quote = _passageDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            _passageDbContext.Quotes.Remove(quote);
        }
    }
}
