using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GymManagement.Controllers
{
    public class TitleController : Controller
    {
        // GET: Title
        public ActionResult Index()
        {
            string name = string.Empty;
            return View();
        }
    }
}