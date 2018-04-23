using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DevExpress.Web.Mvc;

namespace DXM3_HtmlEditor.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            return View();
        }

        public ActionResult HtmlEditorPartial() {
            return PartialView();
        }

        [HttpPost]
        public ActionResult SubmitHtml() {
            ViewBag.PostedHtml = HtmlEditorExtension.GetHtml("htmlEditor");

            return View("Index");
        }
    }
}
