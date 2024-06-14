using Microsoft.AspNetCore.Mvc;
using WebApplication18.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication18.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        IAccountDetails m_accountDetails;
        public AccountController(IAccountDetails accountdetails)
        {
            m_accountDetails = accountdetails;
        }
        // GET: api/<AccountController>
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return m_accountDetails.GetAccounts();
        }

        // GET api/<AccountController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<AccountController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AccountController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
