using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model;

namespace Exam.Repository
{
    public class StudentRepository : BaseRepository<Student>
    {
        public StudentRepository(BusinessDbContext db) : base(db)
        {

        }
        //public string Add(Student student)
        //{
        //    Student added = Db.Students.Add(student);
        //    Db.SaveChanges();
        //    return added.Id;
        //}
    }
}
