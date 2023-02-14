using Microsoft.AspNetCore.Mvc;
using MyWebAPI.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private readonly IPersonService _personService;
        public PersonController(IPersonService personService) 
        {
            this._personService = personService;  

        }
        // GET: api/<Controller>
        [HttpGet]
        public ActionResult<List<Person>> Get()
        {
            return _personService.Get();
        }

        // GET api/<Controller>/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(string id)
        {
            var Person  = _personService.Get(id);
            if(Person == null)
            {
                return NotFound($"Person with Id ={id} not found");
            }
            return Person;
        }

        // POST api/<Controller>
        [HttpPost]
        public ActionResult<Person> Post([FromBody] Person value)
        {
            _personService.Post(value);
            return CreatedAtAction(nameof(Get),new {id = value.Id},value);
        }

        // PUT api/<Controller>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Person value)
        {
            var existingPerson = _personService.Get(id);
            if(existingPerson==null)
            {
                return NotFound($"Student with Id = {id} not found");
            }
            _personService.Put(id, value);
            return NoContent();
        }

        // DELETE api/<Controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var person = _personService.Get(id);
            if(person==null)
            {
                return NotFound($"Student with Id = {id} not found");
            }
            _personService.Delete(id);
            return Ok($"Student with Id = {id} not found");
        }
    }
}
