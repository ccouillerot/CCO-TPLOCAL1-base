using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

namespace TPLOCAL1.Controllers
{
    public class AvisController : Controller
    {
        //methode "naturally" call by router
        public ActionResult AvisList()
        {
            List<Opinion> avislist = OpinionList.GetAvis("/ DataAvis.xml");
            return View(avislist);
        }
    }
}