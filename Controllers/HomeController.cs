using System.Collections.Generic;
using System.Web.Mvc;

namespace SejaHeroi.Controllers
{
    public class HomeController : BaseController
    {
        public override ActionResult Index()
        {  
            return View();
        }
    }
}