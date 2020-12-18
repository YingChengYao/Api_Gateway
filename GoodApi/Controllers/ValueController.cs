using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace GoodApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1 from GoodApi", "value2 from GoodApi" };
        }
    }
}
