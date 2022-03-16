using Microsoft.AspNetCore.Mvc;

namespace TerraformAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetPerson")]
        public Person Get()
        {
            return new Person { Id = 1, Name = "Bob", Age = 40 };
        }
    }
}