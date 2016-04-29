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
   // [Authorize(Roles = "Admin")]
    public class AdminServiceQueryController : ApiController
    {
        AdminServiceService service;

        public AdminServiceQueryController()
        {
            service = new AdminServiceService(new AdminServieRepository(new BusinessDbContext()));
        }

        public IHttpActionResult Get()
        {
            var viewModels = service.GetAll();
            return Ok(viewModels);
        }

    }
}
