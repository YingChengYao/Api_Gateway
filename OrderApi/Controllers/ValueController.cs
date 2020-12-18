using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace OrderApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1 from Order Api", "value2 from Order Api" };
        }
    }
}
