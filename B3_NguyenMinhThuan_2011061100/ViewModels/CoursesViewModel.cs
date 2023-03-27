using B3_NguyenMinhThuan_2011061100.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace B3_NguyenMinhThuan_2011061100.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcommingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}