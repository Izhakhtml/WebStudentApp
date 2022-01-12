using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebStudentApp.Models;

namespace WebStudentApp.Controllers.api
{
    public class StudentsController : Controller
    {
        // GET: Students

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PresentStudentName()
        {
            //ViewBag.Array = StudentsArray();
            return View(StudentsArray());
        }
        public ActionResult PresentAllStudent()
        {
            ViewBag.Array = StudentsArray();
            return View();
        }
        public ActionResult PresentStudent(int id)
        {
            try
            {
                foreach(var item in StudentsArray())
                {  
                     if (item.id == id)
                     {
                         return View(item);
                     }
                         
                }

            }
            catch (Exception ex)
            {
                return View(ex.Message);
            }
            return View();


        }
        public Student[] StudentsArray()
        {
            Student[] students = new Student[]
            {
             new Student(1,"shay","indi","H1",23),
             new Student(2,"moti","NTSE","F2",29),
             new Student(3,"gidon","NIYT","P1",21),
             new Student(4,"baruch","ncvg","G1",28)
            };
            return students;
        }
    }
}