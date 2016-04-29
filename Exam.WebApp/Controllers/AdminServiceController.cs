using Exam.Model;
using Exam.Repository;
using Exam.Service;

namespace Exam.WebApp.Controllers
{
    public class AdminServiceController : BaseController<AdminService>
    {
        public AdminServiceController() : base(new BaseService<AdminService>(new AdminServieRepository(new BusinessDbContext())))
        {
        }
    }
}