using BigschoolPro.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BigschoolPro.Controllers
{
    public class CoursesControllerController : Controller
    {
        // GET: CoursesController
        private readonly ApplicationDbContext _dbContext;
        public CoursesControllerController() 
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Create()
        {
            var viewModel = new CourseViewModel
            {
                Categories = _dbContext.Categories.ToList()
            };
            return View(viewModel);
        }
    }
}