using Microsoft.AspNetCore.Mvc;

namespace ARobinsonMC1SayHllo_EndPnt.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SayHelloController : ControllerBase
    {
        public List<string> NameList = new();

        [HttpPost]
        [Route("InputName/{name}")]
        public List<string> InputName(string name)
        {
            NameList.Add("Hello, " + name);
            return NameList;
        }
    }
}