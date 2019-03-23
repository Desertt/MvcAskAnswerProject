using MvcAskAnswerProject.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAskAnswerProject.UI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            DatabaseContext ct = new DatabaseContext();
            ct.Kullanicilar.ToList();
            return View();
        }

        public ActionResult AskDetail()
        {
            return View();

        }

    }
}