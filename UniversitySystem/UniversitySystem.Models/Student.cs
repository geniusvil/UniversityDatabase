namespace UniversitySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Student
    {
        private ICollection<Course> courses;
        private ICollection<Homework> homeworks;

        public Student()
        {
            this.courses = new HashSet<Course>();
            this.homeworks = new HashSet<Homework>();
        }

        [Key]
        public int StudentId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        public int Level { get; set; }

        public virtual ICollection<Course> Courses
        {
            get
            {
                return this.courses;
            }
            set
            {
                this.courses = value;
            }
        }

        public virtual ICollection<Homework> Homeworks
        {
            get
            {
                return this.homeworks;
            }
            set
            {
                this.homeworks = value;
            }
        }

        public void ShowInfo()
        {
            string courses = String.Empty;
            string homeworks = String.Empty;

            if (this.Courses.Count != 0)
            {
                courses = String.Join(", ", this.Courses);
            }
            else
            {
                courses = "No courses";
            }

            if (this.Homeworks.Count != 0)
            {
                homeworks = String.Join(", ", this.Homeworks);
            }
            else
            {
                homeworks = "No homeworks";
            }

            Console.WriteLine("{0} {1} {2} {3} {4}", this.StudentId, this.FirstName + " " + this.LastName, this.Level, courses, homeworks);
        }
    }
}
