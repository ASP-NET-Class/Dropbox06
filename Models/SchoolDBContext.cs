using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Dropbox06.Models
{
    public class SchoolDBContext: DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<EnrollClub> EnrollClubs { get; set; }
        
        public SchoolDBContext(DbContextOptions<SchoolDBContext> options) : base(options)
        {

        }
    }
}
