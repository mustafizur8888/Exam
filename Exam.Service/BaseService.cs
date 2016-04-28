using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model;
using Exam.Repository;

namespace Exam.Service
{
    public class BaseService<T> where T: Entity
    {
        private BaseRepository<T> repository;

        public BaseService(BaseRepository<T> repository)
        {
            this.repository = repository;

        }

        public bool Add(T entity)
        {
           return repository.Add(entity);
        }
    }
}
