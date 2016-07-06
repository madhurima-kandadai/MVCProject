using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ServiceProject;
using ServiceProject.Entities;
using ServiceProject.Services;

namespace ExampleMVCTests.Controllers
{
    public class HomeController : Controller
    {
        ICategoryService service;
        public HomeController(ICategoryService catService)
        {
            this.service = catService;
        }
        public ActionResult Index()
        {
            return View();
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

        public int InsertCategory(Category category)
        {
           return this.service.InsertCategory(category);
        }
    }
}