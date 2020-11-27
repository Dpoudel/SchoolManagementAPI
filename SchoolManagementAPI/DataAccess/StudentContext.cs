using Microsoft.EntityFrameworkCore;
using SchoolModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SchoolManagementAPI.DataAccess
{
    public class StudentContext:DbContext

    {
        public StudentContext(DbContextOptions<StudentContext> options):base(options)
        {

        }

        public DbSet<Students> Students { get; set; }

        public DbSet<Teachers> teacher { get; set; }
        public DbSet<Class> Grade { get; set; }
        public DbSet<Subjects> Subject { get; set; }
    }
}
