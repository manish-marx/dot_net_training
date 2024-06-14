using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
    public class StudentController : Controller
    {
        public string  Index()
        {
            return "Information";
        }
        public string Name ()
        {
            return "Manish";
        }
        public int Rollnum ()
        {
            return 110;
        }


    }
}
