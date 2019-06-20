using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MITT_Scheduler.Models
{
    public class Course
    {
        public int? CourseId { get; }
        public string CourseName { get; }

        public Course(int? id, string courseName)
        {
            CourseId = id;
            CourseName = courseName;
        }
    }
}