namespace UniversitySystem.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homeworks;

        public Course()
        {
            this.students = new HashSet<Student>();
            this.homeworks = new HashSet<Homework>();
        }

        [Key]
        public int CourseId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public virtual ICollection<Student> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
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
            string students = String.Empty;
            string homeworks = String.Empty;

            if (this.Students.Count != 0)
            {
                students = String.Join(", ", this.Students);
            }
            else
            {
                students = "No students";
            }

            if (this.Homeworks.Count != 0)
            {
                homeworks = String.Join(", ", this.Homeworks);
            }
            else
            {
                homeworks = "No homeworks";
            }

            Console.WriteLine("{0} {1} {2} {3} {4}", this.CourseId, this.Name, this.Description, students, homeworks);
        }
    }
}
