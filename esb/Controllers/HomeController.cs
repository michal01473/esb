using esb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace esb.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        //    private ApplicationDbContext db = new ApplicationDbContext();
        //    public ActionResult Index()
        //    {
        //        ViewBag.Title = "Home Page";

        //        var result = this
        //            .db
        //            .Users
        //            .Select(applicationUser => applicationUser)
        //            .Where (applicationUser => applicationUser.Email == null)

        //        .ToList();
        //        return View();
        //    }
        //}
    }
}