using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Models
{
    public class Course
    {
        private ICollection<Student> students;
        private ICollection<Homework> homework;
        public Course ()
        {
            this.students = new HashSet<Student>();
            this.homework = new HashSet<Homework>();
        }
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
              return  this.homework;
           }
           set
           {
               this.homework = value;
           }
       }

        public void ShowInfo()
        {
            Console.WriteLine("{0} {1}", this.CourseId, this.Name);
        }
    }
}
