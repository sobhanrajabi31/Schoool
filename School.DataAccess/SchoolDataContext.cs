using School.Model.Entities;
using System.Data.Entity;

namespace School.DataAccess
{
    public class SchoolDataContext : DbContext
    {
        public SchoolDataContext() : base("Data Source=.;Initial Catalog=SchoolDB;Integrated Security=True")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Lesson> Lessons { get; set; }
        public DbSet<Class> Classes { get; set; } 
        public DbSet<Register> Registers { get; set; }
    }
}
