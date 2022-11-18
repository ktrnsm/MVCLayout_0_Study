using MVCLayout_0.DesignPatterns.SingletonPattern;
using MVCLayout_0.Models;
using MVCLayout_0.VMClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;

namespace MVCLayout_0.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities _db;
        public CategoryController()
        {
            _db = DBTool.DBInstance;
        }

        // GET: Category
        public ActionResult Index()
        {

            return View();
        }
        public ActionResult ListCategories()
        {
            CategoryVM cvm = new CategoryVM
            {
                Categories = _db.Categories.ToList()
            };
            return View(cvm);
        }
    }
}