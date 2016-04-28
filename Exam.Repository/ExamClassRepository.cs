using Exam.Model;

namespace Exam.Repository
{
    public class ExamClassRepository : BaseRepository<ExamClass>
    {
        public ExamClassRepository(BusinessDbContext db) : base(db)
        {

        }
    }
}