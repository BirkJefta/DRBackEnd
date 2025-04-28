using DRBackEnd.Models;
using DRBackEnd.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DRBackEnd.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class DRPladesamlingsController : ControllerBase
    {
        private DRPladeRepository _repo;
        public DRPladesamlingsController(DRPladeRepository dRPladeRepository)
        {
            _repo = dRPladeRepository;
            _repo.Initiation();
        }
        // GET: api/<DRPladesamlings>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<IEnumerable<string>> Get()
        {

            IEnumerable<DRPladeModel> DRPlades = _repo.Get();

            if (DRPlades == null)
            {
                return NotFound();
            }

            return Ok();
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
