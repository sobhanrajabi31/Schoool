using School.Model.Entities;
using System.Data.Entity;
using System.Configuration;

namespace School.DataAccess
{
    public class SchoolDataContext : DbContext
    {
        public SchoolDataContext() : base(AdoConnection.ConnectionString)
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Class> Classes { get; set; } 
        public DbSet<Register> Registers { get; set; }
    }
}
