using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EFCodeFirstPrj.Models;

namespace EFCodeFirstPrj.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var dal = new ProductDataAccessLayer();
            var lstProducts = dal.GetAllProducts();
            return View(lstProducts);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(tbl_product product)
        {
            var dal = new ProductDataAccessLayer();
            dal.AddProduct(product);

            return RedirectToAction("Index");
        }



        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}