using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DRBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DRPladesamlingsController : ControllerBase
    {
        // GET: api/<DRPladesamlings>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<DRPladesamlings>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<DRPladesamlings>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<DRPladesamlings>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<DRPladesamlings>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
