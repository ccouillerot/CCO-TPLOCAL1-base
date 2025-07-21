using Microsoft.AspNetCore.Mvc;

namespace TPLOCAL1.Controllers
{
    public class FormController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
