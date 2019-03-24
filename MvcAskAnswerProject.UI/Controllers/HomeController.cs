using System.Web.Mvc;

namespace MvcAskAnswerProject.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AskDetail()
        {
            return View();

        }

    }
}