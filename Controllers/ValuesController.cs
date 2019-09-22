using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SeriLogDemo.Model;
using System.Diagnostics;

namespace SeriLogDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly ILogger<ValuesController> _logger;
        private readonly IPersonRepository _repo;

        public ValuesController(ILogger<ValuesController> logger, IPersonRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<Person>> Get()
        {          

            var processName = Process.GetCurrentProcess().ProcessName;            

            return Ok(_repo.GetAllPersons());
            
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Person> Get(int id)
        {
            return Ok(_repo.GetPerson(id));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
