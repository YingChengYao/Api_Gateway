using Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace OrderApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        // GET api/Order/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var item = new Orders
            {
                Id = id,
                Content = $"{id}的订单明细",
            };
            return JsonSerializer.Serialize(item);
        }
    }
}
