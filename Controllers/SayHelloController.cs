using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC1SayHllo_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        public List<string> NameList = new();

        [HttpGet]
        [Route("InputName/{name}")]
        public string InputName(string name)
        {
            return "Hello, " + name;
        }
    }
}