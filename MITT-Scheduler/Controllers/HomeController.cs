using MITT_Scheduler.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MITT_Scheduler.Controllers
{
    public class HomeController : Controller
    {
        private IReadOnlyList<Program> Programs = new List<Program>
        {
            new Program(1, "Software Developer A"),
            new Program(2, "CYBER DEFENCE AND CLOUD ADMINISTRATION"),
            new Program(3, "CCENT AND CCNA CISCO")
        };

        private IReadOnlyList<Course> Courses = new List<Course>
        {
            new Course(1, "Introduction to Web Development"),
            new Course(2, "Technical Writing Skills"),
            new Course(3, "Javascript Basics"),
            new Course(4, "Object Oriented Javascript"),
            new Course(5, "Communication and Presentation Skills"),
            new Course(6, "Mathematics for Computing"),
            new Course(7, "Enterprise Software I"),
            new Course(8, "Enterprise Software II")
        };

        private IReadOnlyList<Room> Rooms = new List<Room>
        {
            new Room(1, "901"),
            new Room(2, "902"),
            new Room(3, "900")
        };

        private IReadOnlyList<Instructor> Instructors = new List<Instructor>
        {
            new Instructor(1, "John"),
            new Instructor(2, "Gui"),
            new Instructor(3, "David")
        };

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AllPrograms()
        {
            return View();
        }

        public ActionResult AllCourses()
        {
            return View();
        }

        public ActionResult CreateProgram()
        {
            return View();
        }

        public ActionResult CreateCourse(CreateCourseBindingModel model)
        {
            model.Programs = Programs.Select(p => new SelectListItem {
                Value = p.ProgramId.ToString(),
                Text = p.ProgramName
            }).ToList();

            model.Courses = Courses.Select(p => new SelectListItem {
                Value = p.CourseId.ToString(),
                Text = p.CourseName
            }).ToList();

            model.Instructors = Instructors.Select(p => new SelectListItem
            {
                Value = p.InstructorId.ToString(),
                Text = p.InstructorName
            }).ToList();

            model.Rooms = Rooms.Select(p => new SelectListItem
            {
                Value = p.RoomId.ToString(),
                Text = p.RoomNumber
            }).ToList();

            return View(model);
        }

        public ActionResult UpdateHolidays()
        {

            return View();
        }

        public ActionResult StudentView(CreateCourseBindingModel model)
        {
            model.Programs = Programs.Select(p => new SelectListItem
            {
                Value = p.ProgramId.ToString(),
                Text = p.ProgramName
            }).ToList();

            return View(model);
        }

        public ActionResult InstructorView(CreateCourseBindingModel model)
        {
            model.Instructors = Instructors.Select(p => new SelectListItem
            {
                Value = p.InstructorId.ToString(),
                Text = p.InstructorName
            }).ToList();

            return View(model);
        }

        public ActionResult RoomView(CreateCourseBindingModel model)
        {
            model.Rooms = Rooms.Select(p => new SelectListItem
            {
                Value = p.RoomId.ToString(),
                Text = p.RoomNumber
            }).ToList();

            return View(model);
        }

        public ActionResult Print(CreateCourseBindingModel model)
        {
            model.Instructors = Instructors.Select(p => new SelectListItem
            {
                Value = p.InstructorId.ToString(),
                Text = p.InstructorName
            }).ToList();

            return View(model);
        }
    }
}