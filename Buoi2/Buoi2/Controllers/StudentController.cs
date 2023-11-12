using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Buoi2.Models;
using System.Web.Mvc;

namespace Buoi2.Controllers
{
    public class StudentController : Controller
    {
        List<Student> studentList = new List<Student>{
                new Student(){StudentId=1,StudentName="Nguyen Quoc Bang",Age=21 },
                new Student(){StudentId=2,StudentName="Do Duc Minh",Age=21 },
                new Student(){StudentId=3,StudentName="Tran Duc Minh",Age=21 },
            };
        // GET: Student
        public ActionResult Index()
        {
            return View(studentList);
        }
        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.StudentId==id).FirstOrDefault();
            return View(std);
        }
    }
}