using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DIEPHOANVU_BIGSHOOL0.Models;


namespace DIEPHOANVU_BIGSHOOL0.Controllers
{
    public class HomeController : Controller
    {
        
        private ApplicationDbContext _dbContext;
        public HomeController()
        {
            _dbContext = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var upcommingCourses = _dbContext.Courses
                .Where(c => c.DateTime > DateTime.Now);
            return View(upcommingCourses);
        }
    }
}