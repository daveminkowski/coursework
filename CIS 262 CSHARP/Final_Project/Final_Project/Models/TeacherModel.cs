﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class TeacherModel
    {
        public int TeacherId { get; set; }

        [Display(Name = "First Name")]
        [Required]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        public string LastName { get; set; }
    }

    public class AllTeachersModel
    {
        public List <TeacherModel> Teachers { get; set; }
    }
}