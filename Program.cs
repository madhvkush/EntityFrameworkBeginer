using EFDemo.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer<EF_DBContext>(new DropCreateDatabaseIfModelChanges<EF_DBContext>());
            using (EF_DBContext context = new EF_DBContext())
            {
                context.Database.Initialize(true); // Force you DB to be initialize
            }

            Console.WriteLine("Database Created/Updated");
            Console.ReadLine();
        }
    }
}
