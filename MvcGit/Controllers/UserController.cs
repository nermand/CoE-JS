using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGit.Models;

namespace MvcGit.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Index()
        {
            ViewBag.Welcome = "Welcome to User List";
            return View();
        }

        public JsonResult GetAllUsers()
        {
            var userList = new List<User>
                {
                    new User() {Name = "Nerman"}, 
                    new User() {Name = "Josip"}, 
                    new User() {Name = "Broz"}
                };

            return Json(userList, JsonRequestBehavior.AllowGet);
        }

    }
}
