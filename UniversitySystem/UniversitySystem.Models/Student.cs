using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Models
{
   public  class Student
    {
       private ICollection<Course> courses;
       private ICollection<Homework> homeworks;

       public Student()
       {
           this.courses = new HashSet<Course>();
           this.homeworks = new HashSet<Homework>();
       }

       public int StudentId{get;set;}
      
      // [Required]
       public string FirstName { get; set; }

      //  [Required]
       public string LastName { get; set; }

       public int Level { get; set; }

       public ICollection<Course> Courses
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

       public ICollection<Homework> Homeworks
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
           Console.WriteLine("{0} {1}", this.StudentId, this.LastName);
       }
    }
}
