using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstLook.Models;

namespace FirstLook.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            Mailing m1 = new Mailing();
            m1.FirstName = "Pete";
            m1.LastName = "Soukup";
            m1.Email = "lm@me.com";

            Mailing m2 = new Mailing();
            m2.FirstName = "Fred";
            m2.LastName = "Estarir";
            m2.Email = "l@e.com";

            List<Mailing> mailings = new List<Mailing>();
            mailings.Add(m1);
            mailings.Add(m2);

            return View(mailings);
        }
    }
}