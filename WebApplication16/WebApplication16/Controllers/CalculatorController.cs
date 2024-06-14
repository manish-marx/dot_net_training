using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication16.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // GET: api/<CalculatorController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<CalculatorController>/5
        [HttpGet("add")]
        public int  Add(int x , int y)
        {
            return x+y;
        }
        [HttpGet("subs")]
        public int Subs (int x , int y)
        {
            return x - y;
        }
        [HttpGet("mult")]
        public int Mult (int x , int y)
        {
            return x * y;
        }
        [HttpGet("Divi")]
        public int Divi (int x , int y)
        {
            return x / y;
        }
        // POST api/<CalculatorController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CalculatorController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CalculatorController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
