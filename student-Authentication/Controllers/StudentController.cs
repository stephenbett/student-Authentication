using student_Authentication.API;
using student_Authentication.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Razor.Tokenizer;

namespace student_Authentication.Controllers
{
    public class StudentController : ApiController
    {

        [AllowAnonymous]
        [HttpGet]
        public IHttpActionResult GetStudent()
        {
            var students = Functions.GetStudents();// Call the SOAP API method to retrieve Applicants

            // var myapplicant = applicants.FirstOrDefault(m=>m.Email ==  )

            List<Student> studentlist = new List<Student>();
            foreach (var student in students)
            {
                var studentDTO = new Student();
                {
                    studentDTO.No = student.No;
                    studentDTO.Name = student.Name;
                    studentDTO.Age = student.Age;
                    studentDTO.Email = student.E_Mail;
                    studentDTO.CourseName = student.Course_Name;
                    studentDTO.SchoolName = student.SchoolName;


                };
                studentlist.Add(studentDTO);
            }
            return Ok(studentlist);

        }
    }
}
