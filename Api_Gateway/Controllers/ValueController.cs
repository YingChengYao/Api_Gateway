﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Api_Gateway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ValueController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1 from Ocelot", "value2 from Ocelot" };
        }
    }
}
