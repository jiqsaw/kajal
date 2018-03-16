using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kajal.Web.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            session.GameSentence = null;
            return View();
        }

    }
}