using Lab_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_1.Controllers
{
    public class MatrixController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Analyze(int rows, int columns)
        {
            if (rows <= 0 || columns <= 0)
            {
                ViewBag.Result = "Invalid matrix size.";
                return View("Index");
            }

            MatrixModel model = new MatrixModel();
            model.GenerateMatrix(rows, columns);
            model.AnalyzeMatrix();

            return View("Results", model);
        }
    }
}
