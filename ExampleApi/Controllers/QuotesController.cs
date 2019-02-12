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
        [HttpGet]
        public IHttpActionResult loadQuotes()
        {
            return Ok(_passageDbContext.Quotes.ToList());
        }

        [HttpGet]
        [Route("api/Quotes/Test/{id:int}")]
        public int Test(int id)
        {
            return id;
        }

        // GET: api/Quotes/5
        public IHttpActionResult loadQuote(int id)
        {

            var quote = _passageDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            if (quote == null) {
                return NotFound();
                    };
            return Ok(quote);
        }

        // POST: api/Quotes
       [HttpPost]
        public IHttpActionResult createQuote([FromBody]Quote value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _passageDbContext.Quotes.Add(value);
            _passageDbContext.SaveChanges();
           return StatusCode(HttpStatusCode.Created);
        }

        // PUT: api/Quotes/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody]Quote value)
        {
            var quote = _passageDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            quote.Title = value.Title;
            quote.Author = value.Author;
            quote.Content = value.Content;
            _passageDbContext.SaveChanges();
            return Ok("Updated successfuly");
        }

        // DELETE: api/Quotes/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {

            var quote = _passageDbContext.Quotes.FirstOrDefault(q => q.Id == id);
            if (quote == null)
            {
                return BadRequest("Record not FOUND AND COULND'T DELETE");
            }
            _passageDbContext.Quotes.Remove(quote);
            return Ok("Deleted");
        }
    }
}
