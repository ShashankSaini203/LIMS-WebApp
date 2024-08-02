using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebApp.Controllers
{
    public class BaseController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
