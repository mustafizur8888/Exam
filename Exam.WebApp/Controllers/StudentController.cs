using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Exam.Model;
using Exam.Repository;
using Exam.Service;

namespace Exam.WebApp.Controllers
{
    public class StudentController : BaseController<Student>
    {
        public StudentController() : base(new BaseService<Student>(new StudentRepository(new BusinessDbContext())))  
        {
        }
    }
}
