using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Final_Project.Models
{
    public class ExamModel
    {
        public int ExamId { get; set; }

        [Display(Name = "Student ID")]
        [Required]
        public int StudentId { get; set; }

        [Display(Name = "Score")]
        [Required]
        public int Score { get; set; }

        public string LetterGrade { get; set; }
    }

    public class AllExamsModel
    {
        public List <ExamModel> Exams { get; set; }
    }
}