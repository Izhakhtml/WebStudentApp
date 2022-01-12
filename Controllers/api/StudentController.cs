using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebStudentApp.Models;

namespace WebStudentApp.Controllers.api
{
    public class StudentController : ApiController
    {
        // GET: api/Student
        public IHttpActionResult Get()
        {
            return Ok(StudentsList());
        }
        // GET: api/Student/5
        public IHttpActionResult Get(int id)
        {
            return Ok(StudentsList().Find(item => item.id == id));
        }
        // POST: api/Student
        public IHttpActionResult Post(Student value)
        {
            StudentsList().Add(value);
            return Ok(value);
        }
        // PUT: api/Student/5
        public IHttpActionResult Put(int id,Student value)
        {
            Student student = StudentsList().Find(item => item.id == id);
            student.id = value.id;
            student.firstName = value.firstName;
            student.lastName = value.lastName;
            student.room = value.room;
            student.age = value.age;
            return Ok(student);
        }
        // DELETE: api/Student/5
        public IHttpActionResult Delete(int id)
        {
            return Ok(StudentsList().Find(item => item.id == id));
        }
        public List<Student> StudentsList()
        {
            List<Student> studentsList = new List<Student>();
            studentsList.AddRange(new Student[]
            {
             new Student(1,"shay","indi","H1",23),
             new Student(2,"moti","NTSE","F2",29),
             new Student(3,"gidon","NIYT","P1",21),
             new Student(4,"baruch","ncvg","G1",28)
            });
            return studentsList;
        }
    }
}
