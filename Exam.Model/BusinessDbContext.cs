﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam.Model
{
    public class BusinessDbContext : DbContext
    {
        public BusinessDbContext() : base("DefaultConnection")
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<AdminService> AdminServices { get; set; }
    }
}
