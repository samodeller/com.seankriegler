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
    public class SettingsController : ControllerBase
    {
        // GET: api/Settings
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Settings/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }     

        // GET: api/Settings/5
        [HttpGet("{id}", Name = "Get")]
        public string GetStadiumByDescription(int id)
        {
            //https://foursquare.com/developers/login?continue=%2Fdevelopers%2Fverify   -- SearchStadiumActivity
            return "value";
        }        
        
        // GET: api/Settings/5
        [HttpGet]
        public Dictionary<string, string> GetPositions()
        {
            var positions = new Dictionary<string, string>
            {
                {"GK", "Goalkeeper"},
                {"SW", "Sweeper"},
                {"CB", "Centre Back"},
                {"LSB", "Left Side Back"},
                {"RSB", "Right Side Back"},
                {"LWB", "Left Wing Back"},
                {"RWB", "Right Wing Back"},
                {"DMF", "Defensive Midfielder"},
                {"LMF", "Left Side Midfielder"},
                {"RMF", "Right Side Midfielder"},
                {"CMF", "Central Midfielder"},
                {"AMF", "Attacking Midfielder"},
                {"LWF", "Left Winger"},
                {"RWF", "Right Winger"},
                {"SS", "Second Striker"},
                {"ST", "Striker"}
            };
            return positions;
        }

        // POST: api/Settings
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Settings/5
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
