using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Exam.Model;

namespace Exam.WebApp.Controllers
{
    public class BaseController : ApiController
    {
        protected BusinessDbContext Db;

        public BaseController()
        {
            Db = new BusinessDbContext();
        }
    }
}
