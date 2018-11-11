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
    public class StatisticController : ControllerBase
    {//http://www.csgnetwork.com/soccerstatscalc.html
        // GET: api/Statistic
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        /// <summary>
        /// TotalNumber of games played
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGamesPlayed(int id)
        {
            return "value";
        }

        /// <summary>
        /// TotalNumber of games Won
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGamesWon(int id)
        {
            return "value";
        }

        /// <summary>
        /// TotalNumber of games Won
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGamesWonPercentage(int id)
        {
            //value = perRound(eval(Soccer.pgwon.value) /(eval(Soccer.pgwon.value) + eval(Soccer.pglost.value)));
            /*
             if (eval(Soccer.pgwon.value) + eval(Soccer.pglost.value) > 0) {

		Soccer.pgwlp.value = perRound(eval(Soccer.pgwon.value) /(eval(Soccer.pgwon.value) + eval(Soccer.pglost.value)));

		}

        if (eval(Soccer.pgwon.value) + eval(Soccer.pglost.value) == 0) {

		Soccer.pgwlp.value = 0;

		}
             */
            return "value";
        }

        /// <summary>
        /// TotalNumber of games Lost
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGamesLost(int id)
        {
            return "value";
        }

        /// <summary>
        /// TotalNumber of games Drawn
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGamesDrawn(int id)
        {
            return "value";
        }

        /// <summary>
        /// Goal difference (or points difference) is calculated as the number of goals (or points) scored in
        /// all league matches minus the number of goals or points conceded.
        /// The difference between Goal For and Goal Against is known as Goal Difference(GD). 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGoalDifference(int id)
        {
            return "value";
        }

        /// <summary>
        /// Goal For(GF): the total number of goals scored by the team in the season.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGoalsFor(int id)
        {
            return "value";
        }

        /// <summary>
        /// Goal Against(GA) the total number of goals conceded by a team in the whole season.
        /// It is the number of goals scored against them by their opponents.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGoalsAgainst(int id)
        {
            return "value";
        }

        // GET: api/Statistic/5
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
        ///  Goals Against Average is a statistic in used in soccer football (as well as ice hockey,
        /// field hockey, lacrosse, water polo and other sports with a goalie) that is used to put a
        /// goalie’s number of goals allowed into perspective with their total playing time.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}", Name = "Get")]
        public string GetGoalAgainstAverage(int id)
        {
            //Goals Against Average = (goals against x game length) / minutes played.
            //https://captaincalculator.com/sports/soccer/goals-against-average-calculator/
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

        // POST: api/Statistic
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Statistic/5
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
