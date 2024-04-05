using Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_1.Controllers
{
    public class TriangleController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckTriangle(double x, double y, double z)
        {
            bool exists = TriangleModel.CheckTriangleExists(x, y, z);
            ViewBag.Exists = exists;
            return View("Index");
        }
    }
}
