using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class PersonsController : Controller
    {
        public IActionResult MyFirstAction()
        {
            Person JohnWick = new Person { FirstName = "John", LastName = "Wick" };
            return View(JohnWick);
        }
    }
}
