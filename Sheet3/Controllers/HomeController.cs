using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContactBLL;
using Sheet3.Models;
using Entities;

namespace Sheet3.Controllers
{
    public class HomeController : Controller
    {
        public Model myModel = new Model();
        // GET: Home
        public ActionResult Index()
        {
            var records = myModel.GetAll();
            return View(records);
        }

        [HttpGet]
        public ActionResult Edit(int Id)
        {
            Business bll = new Business();
            var record = bll.Details(Id);

            return View(record);
        }

        public ActionResult Details(int Id)
        {
            Business bll = new Business();
            var record = bll.Details(Id);
            return View(record);

        }


        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Contact contact)
        {
            // Call business
            Business bll = new Business();
            bll.Add(contact);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int Id)
        {
            Business bll = new Business();
            var record = bll.Details(Id);
            
            return View(record);
        }

        [HttpPost]
        public ActionResult Delete(int Id, String token)
        {
            Business bll = new Business();
            bll.Delete(Id);
            return RedirectToAction("Index");
        }
    }
}