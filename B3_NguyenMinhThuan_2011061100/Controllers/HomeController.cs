using B3_NguyenMinhThuan_2011061100.Models;
using B3_NguyenMinhThuan_2011061100.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace B3_NguyenMinhThuan_2011061100.Controllers
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
                .Include(c => c.Lecturer)
                 .Include(c => c.Category)
                 .Where(c => c.DateTime > DateTime.Now);

            var viewModel = new CoursesViewModel
            {
                UpcommingCourses = upcommingCourses,
                ShowAction = User.Identity.IsAuthenticated
            };

            return View(viewModel);
        }
    }
}