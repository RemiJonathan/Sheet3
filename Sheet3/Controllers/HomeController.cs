using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactBLL;
using Entities;
using Sheet3.Models;

namespace Sheet3.Controllers
{
    public class HomeController : Controller
    {
        public Model myModel = new Model();
        // GET: Home
        public ActionResult Index()
        {
            var records = myModel.GetList();
            return View(records);
        }
    }
}