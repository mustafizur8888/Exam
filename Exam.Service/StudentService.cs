using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model;
using Exam.Repository;


namespace Exam.Service
{
    public class StudentService : BaseService<Student>
    {
        StudentRepository repository;
        public StudentService(StudentRepository repository) : base(repository)
        {
            
        }

        //public string Add(Student student)
        //{

        //    return repository.Add(student);
        //}
    }
}
