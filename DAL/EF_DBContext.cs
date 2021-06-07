using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo.DAL
{
    class EF_DBContext : DbContext
    {
        public DbSet<Entities.Student> Students { get; set; }

        public DbSet<Entities.Course> Courses { get; set; }
        public DbSet<Entities.Book> Books { get; set; }
        public DbSet<Entities.HomeAdress> HomeAdresses { get; set; }
        


    }
}
