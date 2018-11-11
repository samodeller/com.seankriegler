using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace com.seankriegler.stats.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GoalController : ControllerBase
    {
        // GET: api/Goals
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }



        /// <summary>
        /// Goal difference (or points difference) is calculated as the number of goals (or points) scored in all league matches minus the number of goals or points conceded.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGoalDifference(int id)
        {
            return "value";
        }

        /// <summary>
        ///  GF - stands for “Goals For” , i.e. the total number of goals scored by the team in the season.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGoalsFor(int id)
        {
            return "value";
        }

        /// <summary>
        ///  GA - stands for “Goals Against”, i.e. the total number of goals conceded by a team in the whole season.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGoalsAgainst(int id)
        {
            return "value";
        }

        // POST: api/Goals
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Goals/5
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
