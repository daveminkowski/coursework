using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Final_Project.Dal;

namespace Final_Project.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentAdapter adapter = new StudentAdapter();
            List <Student> students = adapter.GetAll();

            foreach (Student student in students)
            {
                Console.WriteLine(student.StudentId + ":" + student.FirstName + " " + student.LastName);
            }
            Console.ReadLine();
        }
    }
}
