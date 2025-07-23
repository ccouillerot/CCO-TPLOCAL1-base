using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

namespace TPLOCAL1.Controllers
{
    public class FormController : Controller
    {
        [HttpPost]
        public IActionResult FormTest()
        {
            return Content($"Hello PL");

        }
    }
}
