using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MITT_Scheduler.Models
{
    public class Instructor
    {
        public int? InstructorId { get; }
        public string InstructorName { get; }

        public Instructor(int? id, string instructorName)
        {
            InstructorId = id;
            InstructorName = instructorName;
        }
    }
}