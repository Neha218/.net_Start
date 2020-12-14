using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _3.DatabaseConnectivity.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SaveProduct()
        {
            return Content("Save Product");
        }
    }
}