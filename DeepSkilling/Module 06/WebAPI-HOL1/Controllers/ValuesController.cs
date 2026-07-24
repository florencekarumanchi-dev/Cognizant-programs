using Microsoft.AspNetCore.Mvc;

namespace WebApiLab1.Controllers
{
    [ApiController]

    [Route("api/[controller]")]

    public class ValuesController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok(new string[]
            {
                "Value1",
                "Value2"
            });
        }

        [HttpPost]

        public IActionResult Post()
        {
            return Ok("Data Inserted");
        }

        [HttpPut]

        public IActionResult Put()
        {
            return Ok("Data Updated");
        }

        [HttpDelete]

        public IActionResult Delete()
        {
            return Ok("Data Deleted");
        }
    }
}