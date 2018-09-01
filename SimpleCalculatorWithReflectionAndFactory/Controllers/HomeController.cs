using SimpleCalculatorWithReflectionAndFactory.Interfaces;
using System.Web.Mvc;

namespace SimpleCalculatorWithReflectionAndFactory.Controllers
{
    public class HomeController : Controller
    {
        IMathEngine engine;

        public HomeController(IMathEngine engine)
        {
            this.engine = engine;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public string CalculateResults(string className, decimal a, decimal b)
        {
            var results = engine.DoMath(className, a, b);
            return results;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}