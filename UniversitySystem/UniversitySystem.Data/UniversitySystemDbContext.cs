namespace UniversitySystem.Data
{
    using UniversitySystem.Data.Migrations;
    using UniversitySystem.Models;
    using System.Data.Entity;

    public class UniversitySystemDbContext : DbContext, IUniversitySystemDbContext
    {
        public UniversitySystemDbContext()
            : base("UniversitySystemDatabase")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<UniversitySystemDbContext, Configuration>());
        }

        public IDbSet<Course> Courses { get; set; }

        public IDbSet<Student> Students { get; set; }

        public IDbSet<Homework> Homeworks { get; set; }


        public  IDbSet<T> Set<T>() where T : class
        {
            return base.Set<T>();
        }

        public  void SaveChanges()
        {
            base.SaveChanges();
        }
    }
}
