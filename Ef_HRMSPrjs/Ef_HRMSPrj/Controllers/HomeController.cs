using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ef_HRMSPrj.Models; //for BLL classes
using EFDataAccessLib;//for Model classes

namespace Ef_HRMSPrj.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            var bll = new HRMSBusinessLayer();
            var lstEmps = bll.GetAllEmps();
            return View(lstEmps);
        }       
        
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(tbl_employee emp)
        {
            var dal = new EFDataAccessLayer();
            dal.AddEmployee(emp);

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var dal = new EFDataAccessLayer();
            var emp = dal.GetEmpById(id);

            return View(emp);
        }

        [HttpPost]
        public ActionResult Edit(tbl_employee emp)
        {
            if (ModelState.IsValid)
            {
                var dal = new EFDataAccessLayer();
                dal.UpdateEmp(emp);
                return RedirectToAction("Index");
            }
            else
            {
                return View(emp);
            }
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {            
            var dal = new EFDataAccessLayer();
            dal.DeleteEmpById(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            var dal = new EFDataAccessLayer();
            var emp = dal.GetEmpById(id);

            return View(emp);
        }
    }
}