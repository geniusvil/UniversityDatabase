namespace UniversitySystem.Data.Migrations
{
    using UniversitySystem.Models;
    using System;
    using System.Data.Entity.Migrations;
    using System.Linq;
using System.Collections.Generic;

    public sealed class Configuration : DbMigrationsConfiguration<UniversitySystemDbContext>
    {
        public Configuration()
        {
            this.AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
           
        }

        protected override void Seed(UniversitySystemDbContext context)
        {
           if(!context.Courses.Any() && !context.Students.Any())
           {
               return;
           }

           var studentFirst = new Student
           {
               FirstName = "Tony",
               LastName = "Steel",
               Level = 6
           };
           context.Students.Add(studentFirst);

           var studentSecond = new Student
           {
               FirstName = "Kevin",
               LastName = "Smith",
               Level = 21,
           };
           context.Students.Add(studentSecond);

           var studentThird = new Student
           {
               FirstName = "Sam",
               LastName = "Green",
               Level = 1
           };
           context.Students.Add(studentThird);

           var studentForth = new Student
           {
               FirstName = "Henry",
               LastName = "Waiting",
               Level = 4
           };
           context.Students.Add(studentForth);

           var studentFifth = new Student
           {
               FirstName = "Terry",
               LastName = "Ostin",
               Level = 8
           };
           context.Students.Add(studentFifth);
           context.SaveChanges();

           var courseFirst = new Course
           {
               Name = "Playnig Guitar",
               Description = "Learning how to play guitar",
               Students = new HashSet<Student> { studentThird, studentFifth, studentForth, studentSecond },

           };
           context.Courses.Add(courseFirst);

           var courseSecond = new Course
           {
               Name = "Drawing Manga",
               Description = "Learning how to draw manga",
               Students = new HashSet<Student> { studentFirst, studentForth, studentSecond },
           };

           context.Courses.Add(courseSecond);
           context.SaveChanges();
        }
    }
}
