using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Exam.Model;
using Exam.Service;

namespace Exam.WebApp.Controllers
{
    public class StudentController : BaseController
    {
        public IHttpActionResult Post(Student student)
        {
            StudentService service = new StudentService(Db);
            if (string.IsNullOrWhiteSpace(student.Id))
            {
                student.Id = Guid.NewGuid().ToString();
            }
            // this is a test
            string addedId = service.Add(student);
            return Ok(addedId);
        }
    }
}
