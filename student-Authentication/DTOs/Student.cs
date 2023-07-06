using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace student_Authentication.DTOs
{
    public class Student
    {
        public string No { get; set; }
        public string Name { get; set; }
        public string CourseName { get; set; }
        public string SchoolName { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone_No { get; set; }
        public string Stuent_Category { get; set; }
    }
}