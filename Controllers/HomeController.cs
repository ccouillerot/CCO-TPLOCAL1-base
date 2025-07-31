using Microsoft.AspNetCore.Mvc;

using TPLOCAL1.Models;

//Subject is find at the root of the project and the logo in the wwwroot/ressources folders of the solution
//--------------------------------------------------------------------------------------
//Careful, the MVC model is a so-called convention model instead of configuration,
//The controller must imperatively be name with "Controller" at the end !!!
namespace TPLOCAL1.Controllers
{
    public class HomeController : Controller
    {
        //methode "naturally" call by router
        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
                //retourn to the Index view (see routing in Program.cs)
                return View();
            else
            {
                //Call different pages, according to the id pass as parameter
                switch (id)
                {
                    case "ListeAvis":
                        //TODO : code reading of the xml files provide
                        return View(id);
                    case "Formulaire":
                        //TODO : call the Form view with data model empty
                        return View(id);
                    default:
                        //retourn to the Index view (see routing in Program.cs)
                        return View();
                }
            }
        }


        //methode to send datas from form to validation page
        [HttpPost]
        public ActionResult ValidationFormulaire(FormModel form)
        {
            //TODO : test if model's fields are set
            //if not, display an error message and stay on the form page
            //else, call ValidationForm with the datas set by the user
            bool error = false;
            if (form.Sexe == "selsexe")
            {
                ModelState.AddModelError("", "Choisir un sexe");
                error = true;
            }
            if (form.Cour == "seluneformation")
            {
                ModelState.AddModelError("", "Choisir une formation");
                error = true;
            }
            if ((form.Adresse == null) || (form.Adresse.Length < 5))
            {
                ModelState.AddModelError("", "adresse trop courte");
                error = true;
            }
            if (((form.Cour == "Cobol") || (form.Cour == "Double Compétences")) && (form.CobolFormation == null))
            {
                ModelState.AddModelError("", "Décrire votre formation Cobol");
                error = true;
            }
            if (((form.Cour == "C#") || (form.Cour == "Double Compétences")) && (form.CobolFormation == null))
            {
                ModelState.AddModelError("", "Décrire votre formation Objet");
                error = true;
            } 
            if (error == true)
            {
              
               return View("Formulaire");
               //return Redirect("Index/Formulaire");
            }
            return View(form);
        }
    }
}