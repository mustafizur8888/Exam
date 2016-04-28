using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam.Model;

namespace Exam.Repository
{
    public class BaseRepository<T> where T : Entity
    {
        public BusinessDbContext Db { get; set; }
        protected BaseRepository(BusinessDbContext db)
        {
            this.Db = db;
        }

        public bool Add(T entity)
        {
            DbSet<T> dbset = Db.Set<T>();
            T add = dbset.Add(entity);

            return Db.SaveChanges() > 0;
        }
    }
}
