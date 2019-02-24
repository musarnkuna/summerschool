using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace StudentPortal.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        [ForeignKey("Course")]
        public int CourseID { get; set; }
    }
}