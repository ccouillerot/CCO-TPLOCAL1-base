using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

namespace TPLOCAL1.Controllers
{
    public class AvisController : Controller
    {
        //methode "naturally" call by router
        public ActionResult ListeAvis()
        {
            //     OpinionList avislist = new OpinionList();
            //     avislist.GetAvis("/XXDataAvis.xml");
            //     return View(avislist);
            return View();
        }
    }
}