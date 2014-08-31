namespace UniversitySystem.ConsoleClient
{
    using System;
    using System.Linq;

    using UniversitySystem.Data;
    using UniversitySystem.Models;

    class Program
    {
        static void Main(string[] args)
        {

            var db = new UniversitySystemData();

            var courseGuitar = db.Courses.SearchFor(c => c.Name == "Playnig Guitar").First();
            var courseManga = db.Courses.SearchFor(c => c.Name == "Drawing Manga").First();
            var studentGuitar = db.Students.SearchFor(s => s.StudentId == 3).First(); // това тук не ми харесва като метод за намиране ан студент
            var studentManga = db.Students.SearchFor(s => s.StudentId == 1).First();// това тук не ми харесва като метод за намиране ан студент
         
            var homeworkFirst = new Homework
            {
                FileUrl = @"http:///en.wikipedia.org/wiki/Guitar",
                TimeSent = new DateTime(2014, 09, 03),
                CourseId = courseGuitar.CourseId,
                StudentId = studentGuitar.StudentId

            };
            db.Homeworks.Add(homeworkFirst);
            db.SaveChanges();

            var homeworkSecond = new Homework
            {
                FileUrl = @"http:///en.wikipedia.org/wiki/Manga",
                TimeSent = new DateTime(2014, 09, 06),
                CourseId = courseManga.CourseId,
                StudentId = studentManga.StudentId
            };
            db.Homeworks.Add(homeworkSecond);
           db.SaveChanges();

            var coursesDb = db.Courses.All();
            Console.WriteLine("--Courses---");
            foreach (var course in coursesDb)
            {
                course.ShowInfo();
            }

            var studentsDb = db.Students.All();
            Console.WriteLine("\n--Students---");
            foreach (var student in studentsDb)
            {
                student.ShowInfo();
            }

            var homeworksDb = db.Homeworks.All();
            Console.WriteLine("\n--Homeworks---");
            foreach (var homework in homeworksDb)
            {
                homework.ShowInfo();
            }
        }
    }
}
