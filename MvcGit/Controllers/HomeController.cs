﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcGit.Models;

namespace MvcGit.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Simple Example Of Knockout Bindings";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        [HttpGet]
        public JsonResult TaskList()
        {
            var taskList = new List<Task>
                {
                    new Task() {Title = "Learn Javascript Frameworks", TaskType = 0},
                    new Task() {Title = "Master .Net MVC", TaskType = 2},
                    new Task() {Title = "Get familiar with Git", TaskType = 1, IsDone = true}
                };


            return Json(taskList, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetTaskTypes()
        {
            var types = new List<TaskType>
                {
                    new TaskType() {Id = 0, Type = "Bug"},
                    new TaskType() {Id = 1, Type = "Test"},
                    new TaskType() {Id = 2, Type = "Enhancement"}
                };

            return Json(types, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveForm(IEnumerable<Task> tasks)
        {
            return  Json(new {success = true, listSize= tasks.Count().ToString()});
        }
    }
}
