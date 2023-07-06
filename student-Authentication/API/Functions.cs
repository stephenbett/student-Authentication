using student_Authentication.RegisteredStudentRef;
using student_Authentication.RegisteredStudentListRef;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Web;

namespace student_Authentication.API
{
    public class Functions
    {

        public static List<RegisteredStudent> GetStudents()
        {
            List<RegisteredStudent> students = new List<RegisteredStudent>();
            students = Webservice.studentcard_service().ReadMultiple( null,null,0).ToList();

            return students;
        }
        public static RegisteredStudent GetStudent(string No)
        {
           var student = Webservice.studentcard_service().Read(No);
            return student;
        }

        public static RegisteredStudent UpdateStudent(RegisteredStudent No)
        {
            Webservice.studentcard_service().Update(ref No);
            return No;
        }
    }

    public class Webservice
    {

        public static RegisteredStudent_Service studentcard_service()
        {
            RegisteredStudent_Service service = new RegisteredStudent_Service();
            service.Url = ConfigurationManager.AppSettings["path"] + "Page/RegisteredStudent";
            service.UseDefaultCredentials = false;
            service.Credentials = credentials;

            return service;
        }
        public static RegisteredStudentList_Service studentlist_service()
        {
            RegisteredStudentList_Service service = new RegisteredStudentList_Service();
            service.Url = ConfigurationManager.AppSettings["path"] + "Page/RegisteredStudentList";
            service.UseDefaultCredentials = false;
            service.Credentials = credentials;

            return service;

        }
        private static NetworkCredential credentials = new NetworkCredential(ConfigurationManager.AppSettings["SoapUsername"], ConfigurationManager.AppSettings["SoapPassword"]);

    }
}