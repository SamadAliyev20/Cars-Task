using Cars_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars_Task.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Marks> marks = new List<Marks>
            {
                new Marks{Id=1,Name="Mercedes"},
                new Marks{Id=2,Name="BMW"},
                new Marks{Id=3,Name="Audi"}
            };





            return View(marks);
        }
    }
}
