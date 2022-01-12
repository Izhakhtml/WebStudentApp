using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebStudentApp.Models
{
    public class Student
    {
        public int id;
        public string firstName;
        public string lastName;
        public string room;
        public int age;

        public Student(int id, string firstName, string lastName, string room, int age)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.room = room;
            this.age = age;
        }
        public Student() { }
    }
}