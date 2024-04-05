using Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_1.Controllers
{
    public class OctantController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CheckOctant(double x, double y, double z)
        {
            string octant = OctantModel.GetOctant(x, y, z);
            ViewBag.Octant = octant;
            return View("Index");
        }
    }
}
