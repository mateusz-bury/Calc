using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class CalcController : Controller
    {
        public IActionResult Index()
        {
            return View(new calc());
        }

        [HttpPost]

        public ActionResult Index(calc c, string calculate)
        {

            if (calculate == "add")
            {
                c.tot = c.no1 + c.no2;
            }
            else if (calculate == "min")
            {
                c.tot = c.no1 - c.no2;
            }
            else if (calculate == "sub")
            {
                c.tot = c.no1 * c.no2;
            }
            else
            {
                c.tot = c.no1 / c.no2;
            }
            return View(c);
        }
    }
}
