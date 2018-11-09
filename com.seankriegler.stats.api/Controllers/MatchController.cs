using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace com.seankriegler.stats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MatchController : ControllerBase
    {
        // GET: api/Match
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new[] { "value1", "value2" };
        }

        // GET: api/Match/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // GET: api/Match/5
        [HttpGet]
        public List<int> GetMatchTime()
        {
            int[] items = { 5, 10, 15, 20, 25, 30, 35, 40, 45, 50 };
            return items.ToList();
        }

        // GET: api/Match/5
        [HttpGet]
        public List<int> GetRounds()
        {
            int[] items = { 1, 2, 3, 4, 5, 6 };
            return items.ToList();
        }

        // POST: api/Match
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Match/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
