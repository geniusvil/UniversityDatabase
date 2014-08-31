namespace UniversitySystem.Data.Migrations
{
    using UniversitySystem.Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;

    public sealed class Configuration : DbMigrationsConfiguration<UniversitySystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
           
        }

        protected override void Seed(UniversitySystemDbContext context)
        {
            this.SeedCourses(context);
            this.SeedStudents(context);
            this.SeedHomework(context);
        }
      

        private void SeedStudents(UniversitySystemDbContext context)
        {
            if (context.Students.Any())
            {
                return;
            }

            context.Students.Add(new Student
            {
                FirstName = "Tony",
                LastName = "Steel",
                Level = 13
            });

            context.Students.Add(new Student
            {
                FirstName = "Kevin",
                LastName = "Smith",
                Level = 21,
            });

            context.Students.Add(new Student
            {
                FirstName = "Henry",
                LastName = "Waiting",
                Level = 4
            });

            context.Students.Add(new Student
            {
                FirstName = "Terry",
                LastName = "Ostin",
                Level = 8
            });
            context.SaveChanges();
        }

        private void SeedCourses(UniversitySystemDbContext context)
        {
            if (context.Courses.Any())
            {
                return;
            }

            context.Courses.Add(new Course
            {
                Name = "Drawing Manga",
                Description = "Learning how to draw manga"
            });

            context.Courses.Add(new Course
            {
                Name = "Playnig Guitar",
                Description = "Learning how to play guitar"
            });

            context.SaveChanges();
        }

        private void SeedHomework(UniversitySystemDbContext context)
        {
            if (context.Homeworks.Any())
            {
                return;
            }

            context.Homeworks.Add(new Homework
            {
                FileUrl = @"http:///en.wikipedia.org/wiki/Guitar",
                TimeSent = new DateTime(2014,09,03),
            });

            context.Homeworks.Add(new Homework
            {
                FileUrl = @"http:///en.wikipedia.org/wiki/Manga",
                TimeSent = new DateTime(2014, 09, 06),
            });

            context.SaveChanges();
        }
    }
}
