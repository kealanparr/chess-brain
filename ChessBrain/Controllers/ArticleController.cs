using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChessBrain.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        public ActionResult Display(string id)
        {
            return View();
        }
    }
}