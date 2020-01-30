using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project.Dal
{
    public class Exam
    {
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int Score { get; set; }
        public string LetterGrade { get; set; }
    }
}
