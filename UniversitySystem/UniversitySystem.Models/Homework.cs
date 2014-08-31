namespace UniversitySystem.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        [Key]
        public int HomeworkId { get; set; }

        public string FileUrl { get; set; }

        public DateTime TimeSent { get; set; }

       // [ForeignKey("Student")]
        public int StudentId { get; set; }

     //   public virtual Student Student { get; set; }

       // [ForeignKey("Course")]
        public int CourseId { get; set; }

     //   public virtual Course Course { get; set; }

        public void ShowInfo()
        {
            string student = String.Empty;
            string course = String.Empty;

            if (this.StudentId != null)
            {
                student = string.Format("{0}", this.StudentId);
            }
            else
            {
                student = "No student";
            }

            if (this.StudentId != null)
            {
                course = string.Format("{0}", this.CourseId);
            }
            else
            {
                course = "No course";
            }

            Console.WriteLine("{0} {1} {2} {3} {4}", this.HomeworkId, this.FileUrl, this.TimeSent, student, course);
        }
    }
}
