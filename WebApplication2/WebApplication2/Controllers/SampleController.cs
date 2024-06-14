using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class SampleController : Controller
    {
        public string  Index()
        {
            return "Hello World";
        }
        public string Firstname()
        {
            return "Manish";
        }
        public string Lastname()
        {
            return "Kumar";
        }
    }
}
