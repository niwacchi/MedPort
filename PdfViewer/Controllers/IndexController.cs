using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PdfViewer.Controllers
{
    public class IndexController : Controller
    {
        public ActionResult Index()
        {
            var model  = new PdfViewer.Models.Pdf().path;
            return View(model);
        }
    }
}