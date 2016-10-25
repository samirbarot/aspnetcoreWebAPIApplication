using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    public class DataController : Controller
    {

        [Route("/api/hello/{name}")]
        [HttpGet]
        public string Hello(string name) => $"Returning response from CORS Web API v4 - { name }";

        // GET api/data
        [HttpGet]
        public IEnumerable<string> Get() => new string[] { "value1", "value2" };

        // GET api/data/5
        [HttpGet("{id}")]
        public string Get(int id) => "value";

        // POST api/data
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/data/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/data/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
