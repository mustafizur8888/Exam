using Exam.Model;
using Exam.Repository;

namespace Exam.Service
{
    public class ExammClassService : BaseService<ExamClass>
    {
        ExamClassRepository repository;

        public ExammClassService(ExamClassRepository repository) : base(repository)
        {

        }
    }
}