using EquisApp.DataServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EquisApp.Controllers
{
    public class HomeController : Controller
    {
        #region properties
        public User User { get; set; }
        public bool IsLogin { get; set; }
        #endregion
        protected override void OnActionExecuting(ActionExecutingContext ActualRequest)
        {
            if (Session["CurrentUser"] == null)
            {
                base.OnActionExecuting(ActualRequest);
                //ActualRequest.Result = RedirectToAction("login", "Login");

            }

            if (Session["CurrentUser"] != null)
            {
                base.OnActionExecuting(ActualRequest);
            }

        }

        public ActionResult Index()
        {
            return View();
        }

              

        public ActionResult Users()
        {

            RedirectToAction("login", "Login");

            return View();
        }
    }
}