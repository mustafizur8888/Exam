using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model;
namespace Exam.Service
{
    public class BaseService
    {
        protected BusinessDbContext DbContext;
        public BaseService(BusinessDbContext db)
        {
            DbContext = db;

        }
    }
}
