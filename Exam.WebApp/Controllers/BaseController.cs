using System;
using System.Web.Http;
using Exam.Model;
using Exam.Service;

namespace Exam.WebApp.Controllers
{
    public class BaseController<T> : ApiController where T:Entity
    {
       
        protected BaseService<T> Service; 
        
        public BaseController(BaseService<T> service )
        {
            
            this.Service = service;
        }

        public IHttpActionResult Post(T entity)
        {
           // StudentService service = new StudentService(new StudentRepository(new BusinessDbContext()));
            if (string.IsNullOrWhiteSpace(entity.Id))
            {
                entity.Id = Guid.NewGuid().ToString();
            }
            // this is a test
            var addedId = Service.Add(entity);
            return Ok(addedId);
        }
    }
}
