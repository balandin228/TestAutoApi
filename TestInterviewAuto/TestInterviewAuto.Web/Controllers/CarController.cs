using Microsoft.AspNetCore.Mvc;

namespace TestInterviewAuto.Web.Controllers
{
    public class CarController : Controller
    {
        // GET
        public IActionResult Index()
        {
            return View();
        }
    }
}