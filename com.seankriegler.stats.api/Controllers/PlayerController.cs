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
    public class PlayerController : ControllerBase
    {
        // GET: api/Player
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Player/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        /// <summary>
        /// Get Hat-Trick count by player for all matches they have played
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetHatTrickCount(int id)
        {
            return "value";
        }

        /// <summary>
        ///  Goal average means the number of goals scored divided by the number of goals conceded
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGoalAverage(int id)
        {
            return "value";
        }

        // GET: api/Statistic/5
        /// <summary>
        ///  Save percentage is a statistic in soccer (as well as ice hockey, field hockey, lacrosse,
        /// water polo, and other sports with a goalie) that is used to put a goalie’s number of saves
        /// comparison with the number of shots they have faced.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetSavePercentage(int id)
        {
            // Save Percentage = saves/shots against.
            // https://captaincalculator.com/sports/soccer/save-percentage-calculator/
            return "value";
        }

        // GET: api/Statistic/5
        /// <summary>
        /// Shooting percentage is a statistic used in soccer (as well as ice hockey, field hockey,
        /// lacrosse, water polo and other sports with a goalie) that is used to put a player’s
        /// number of goals made in comparison with their total shots made.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetShootingPercentage(int id)
        {
            // Shooting Percentage = goals scored / shots on goal taken.
            // https://captaincalculator.com/sports/soccer/save-percentage-calculator/
            return "value";
        }

        // POST: api/Player
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Player/5
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

    public enum StrongFoot
    {
        Rightfooted = 1,
        Leftfooted = 2,
        BothFeet = 3
    }

    public enum Carded
    {
        Red = 1,
        Yellow = 2
    }

    public enum GameType
    {
        GROUP_STAGE,
        LEAGUE,
        TOURNAMENT,
        FRIENDLY
    }
}
