using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pdf6b2.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options)
        {

        }
        
        public DbSet<Student> Students { get; set; }

        public DbSet<Subject> Subjects { get; set; }

        public DbSet<Mark> Marks { get; set; }
    }
}
