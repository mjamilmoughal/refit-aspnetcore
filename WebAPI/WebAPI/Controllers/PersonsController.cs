using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;


namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {

        private static List<Person> persons = new List<Person>()
        {
            new Person{Id=1, FullName="Usman",Email="usman@gmail.com",City="Mirpur", Country="Pakistan"},
            new Person{Id=2, FullName="Jolly",Email="jolly@gmail.com",City="Rome", Country="Italy"},
            new Person{Id=3, FullName="Tina",Email="tina@gmail.com",City="Berlin", Country="Germany"},
            new Person{Id=4, FullName="Anil",Email="anil@gmail.com",City="Mumbai", Country="India"},
        };

        // GET: api/<PersonsController>
        [HttpGet]
        public IEnumerable<Person> Get()
        {
            return persons;
        }

        // GET api/<PersonsController>/5
        [HttpGet("{id}")]
        public Person Get(int id)
        {
            return persons.Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/<PersonsController>
        [HttpPost]
        public void Post([FromBody] Person person)
        {
            persons.Add(person);
        }

        // PUT api/<PersonsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Person person)
        {
            persons.Remove(persons.Where(x => x.Id == id).FirstOrDefault());
            persons.Add(person);
        }

        // DELETE api/<PersonsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            persons.Remove(persons.Where(x => x.Id == id).FirstOrDefault());
        }
    }
}
