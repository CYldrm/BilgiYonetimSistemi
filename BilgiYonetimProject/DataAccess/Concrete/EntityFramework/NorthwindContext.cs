using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //Db tabloları ile classları bağlamak
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;
                                          Database=BilgiYonetim;Trusted_Connection=true;");
        }
        
        public DbSet<Answer> Answer { get; set; }
        public DbSet<Brand> Brand { get; set; }
        public DbSet<Process> Process { get; set; }
        public DbSet<Question> Question { get; set; }
        public DbSet<QuestionGroup> QuestionGroup { get; set; }
        public DbSet<Survey> Survey { get; set; }
        public DbSet<User> User { get; set; }

    }
}
