﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace B3_NguyenMinhThuan_2011061100.Models
{
    public class Course
    {
        public int Id { get; set; } 
        public ApplicationUser Lecturer { get; set; }
        [Required]
        public string LecturerId { get; set; }
        [Required]
        [StringLength(255)]
        public string Place{ get; set; }


        [Required]
        public DateTime DateTime { get; set; }

        public Category Category { get; set; }


    }
    
}