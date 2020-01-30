using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Final_Project.Models;
using Final_Project.Dal;

namespace Final_Project.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Index(int studentId = 0)
        {
            ExamAdapter adapter = new ExamAdapter();
            List <Exam> exams = adapter.GetAll();
            if (studentId == 0)
            {
                exams = adapter.GetAll();
            }
            else
            {
                exams = adapter.GetByStudentId(studentId);
            }

            AllExamsModel model = new AllExamsModel();

            List <ExamModel> examModels = new List <ExamModel>();
            foreach (Exam exam in exams)
            {
                
                ExamModel examModel = new ExamModel();
                examModel.ExamId = exam.ExamId;
                examModel.StudentId = exam.StudentId;
                examModel.Score = exam.Score;

                String grade;
                if (examModel.Score >= 90)
                    grade = "A";
                else if (examModel.Score >= 80 && examModel.Score < 90)
                    grade = "B";
                else if (examModel.Score >= 70 && examModel.Score < 80)
                    grade = "C";
                else if (examModel.Score >= 60 && examModel.Score < 70)
                    grade = "D";
                else
                    grade = "F";
                examModel.LetterGrade = grade;

                examModels.Add(examModel);

            }
            model.Exams = examModels;
            return View(model);
        }

        public ActionResult Add()
        {
            ExamModel model = new ExamModel();
            return View(model);
        }

        [HttpPost]
        public ActionResult Add(ExamModel model)
        {
            if (ModelState.IsValid)
            {
                ExamAdapter examAdapter = new ExamAdapter();
                Exam exam = new Exam();
                exam.Score = model.Score;
                exam.StudentId = model.StudentId;

                String grade;
                if (exam.Score >= 90)
                    grade = "A";
                else if (exam.Score >= 80 && exam.Score < 90)
                    grade = "B";
                else if (exam.Score >= 70 && exam.Score < 80)
                    grade = "C";
                else if (exam.Score>= 60 && exam.Score < 70)
                    grade = "D";
                else
                    grade = "F";
                exam.LetterGrade = grade;

                bool returnValue = examAdapter.InsertExam(exam);
                if (returnValue)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            return View(model);
        }

        public ActionResult Edit(int examId)
        {
            ExamAdapter examAdapter = new ExamAdapter();
            Exam exam = examAdapter.GetById(examId);
            if (exam == null)
            {
                return RedirectToAction("Index");
            }
            else
            {
                ExamModel model = new ExamModel();
                model.ExamId = exam.ExamId;
                model.Score = exam.Score;

                String grade;
                if (model.Score >= 90)
                    grade = "A";
                else if (model.Score >= 80 && model.Score < 90)
                    grade = "B";
                else if (model.Score >= 70 && model.Score < 80)
                    grade = "C";
                else if (model.Score >= 60 && model.Score < 70)
                    grade = "D";
                else
                    grade = "F";
                model.LetterGrade = grade;

                model.StudentId = exam.StudentId;

                return View(model);
            }
        }

        [HttpPost]
        public ActionResult Edit(ExamModel model)
        {
            if (ModelState.IsValid)
            {
                ExamAdapter examAdapter = new ExamAdapter();
                Exam exam = new Exam();
                exam.ExamId = model.ExamId;
                exam.Score = model.Score;

                String grade;
                if (exam.Score >= 90)
                    grade = "A";
                else if (exam.Score >= 80 && exam.Score < 90)
                    grade = "B";
                else if (exam.Score >= 70 && exam.Score < 80)
                    grade = "C";
                else if (exam.Score >= 60 && exam.Score < 70)
                    grade = "D";
                else
                    grade = "F";
                exam.LetterGrade = grade;

                exam.StudentId = model.StudentId;

                bool returnValue = examAdapter.UpdateExam(exam);
                if (returnValue)
                {
                    return RedirectToAction("Index");
                }
                else
                {
                    return View(model);
                }
            }
            return View(model);
        }

        public ActionResult Delete(int examId)
        {
            ExamAdapter examAdapter = new ExamAdapter();
            bool returnValue = examAdapter.DeleteExam(examId);
            return RedirectToAction("Index");
        }
    }
}