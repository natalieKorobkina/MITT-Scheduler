using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MITT_Scheduler.Models
{
    public class CreateCourseBindingModel
    {
        [Display(Name = "Instructor Name")]
        public int InstructorId { get; set; }
        public IEnumerable<SelectListItem> Instructors { get; set; }

        [Display(Name = "Program Name")]
        public int ProgramId { get; set; }
        public IEnumerable<SelectListItem> Programs { get; set; }
        
        [Display(Name = "Course Name")]
        public int CourseId { get; set; }
        public IEnumerable<SelectListItem> Courses { get; set; }

        [Display(Name = "Room Number")]
        public int RoomId { get; set; }
        public IEnumerable<SelectListItem> Rooms { get; set; }

        [Display(Name = "Start Date")]
        public DateTime StartDate { get; set; }

        [Display(Name = "End Date")]
        public DateTime EndDate { get; set; }

        [Display(Name = "Start Time")]
        public DateTime StartTime { get; set; }

        [Display(Name = "End Time")]
        public DateTime EndTime { get; set; }

    }
}