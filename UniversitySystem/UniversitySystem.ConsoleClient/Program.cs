namespace UniversitySystem.ConsoleClient
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using UniversitySystem.Data;
    using UniversitySystem.Models;

    class Program
    {
        static void Main(string[] args)
        {

            var db = new UniversitySystemData();

            using (db)
            {

                var coursesDb = db.Courses.All();

                foreach (var course in coursesDb)
                {
                    course.ShowInfo();
                }

                var studentsDb = db.Students.All();
                foreach (var student in studentsDb)
                {
                    student.ShowInfo();
                }

                var homeworksDb = db.Students.All();
                foreach (var homework in homeworksDb)
                {
                    homework.ShowInfo();
                }
            }

        }
    }
}
