using Microsoft.AspNetCore.Mvc;

namespace LIMS.WebAPI.Controllers
{
    public class OrderDetailsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
