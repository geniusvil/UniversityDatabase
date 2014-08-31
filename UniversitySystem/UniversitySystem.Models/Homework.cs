using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniversitySystem.Models
{
   public  class Homework
    {
        public int HomeworkId { get; set; }
        public string  FileUrl { get; set; }

        public DateTime TimeSent { get; set; }

        public int StudentId { get; set; }

       //[ForeignKey("Course")]
       public int CourseId { get; set; }

      public virtual Course Course { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine("{0} {1}", this.HomeworkId, this.FileUrl);
        }
    }
}
