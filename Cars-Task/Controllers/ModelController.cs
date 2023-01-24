
using Cars_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Cars_Task.Controllers
{
    
    public class ModelController : Controller
    {
        private readonly List<Model> _models;

        public ModelController()
        {
            _models = new List<Model>
            {
             new Model{ Id=1, Name="170V", MarkId=1,Description="Mercedes 170 V, 2.4 L, 1938 il, 82 000 km"},
             new Model{ Id=2, Name="CLS 63 AMG", MarkId=1,Description="Mercedes CLS 63 AMG, 5.5 L, 2011 il, 78 000 km"},
             new Model{ Id=3, Name="G 63 AMG", MarkId=1,Description="Mercedes C 63 AMG, 4.0 L, 2017 il, 44 000 km"},
             new Model{ Id=4, Name="330", MarkId=2,Description="BMW 330, 2.0 L, 2019 il, 52 385 km"},
             new Model{ Id=5, Name="640", MarkId=2,Description="BMW 640, 3.0 L, 2013 il, 147 000 km"},
             new Model{ Id=6, Name="740", MarkId=2, Description = "BMW 740, 3.0 L, 2018 il, 87 000 km"},
             new Model{ Id=7, Name="100", MarkId=3, Description = "Audi 100, 2.4 L, 1985 il, 300 000 km"},
             new Model{ Id=8, Name="80", MarkId=3, Description = "Audi 80, 1.6 L, 1990 il, 220 000 km"},
             new Model{ Id=9, Name="A4", MarkId=3, Description = "Audi A4, 1.8 L, 2002 il, 262 000 km"},
            };
        }

        public IActionResult Index(int? id)
        {
            if (id == null)
            {
                return View(_models);
            }
            if (_models.Exists(s=>s.MarkId == id))
            {
                return View(_models.FindAll(s => s.MarkId == id));
            }
            else
            {
                return BadRequest();
            }
        }
        public IActionResult Detail(int? id)
        {
            if (id == null)
            {
                return BadRequest();
            }
            if (_models.Exists(s => s.Id == id))
            {
                return View(_models.Find(s => s.Id == id));
            }
            else
            {
                return NotFound();
            }
        }

    }
}
