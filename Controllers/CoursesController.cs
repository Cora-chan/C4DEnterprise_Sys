using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using C4DEnterpriseSys_ver1.Models;
using System.Data.Entity;
using C4DEnterpriseSys_ver1.ViewModels;

namespace C4DEnterpriseSys_ver1.Controllers
{
    public class CoursesController : Controller
    {
        private ApplicationDbContext _context;

        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }


        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageCourses))
                return View("Index");
            else
                return View("ReadOnlyList");
        }

        [Authorize(Roles =RoleName.CanManageCourses)]
        public ActionResult AddNewCourse()
        {
            var classtypes = _context.CTypes.ToList();
            var semesters = _context.Semesters.ToList();
            var genres = _context.Genres.OrderBy(g => g.Name).ToList();
            var rooms = _context.Rooms.ToList();
            var levels = _context.Levels.ToList();
            var dayinweeks = _context.DayInWeeks.ToList();
            var viewModel = new CourseFormViewModel
            {
                CTypes = classtypes,
                Semesters = semesters,
                Genres = genres,
                Rooms = rooms,
                Levels=levels,
                DayInWeeks= dayinweeks
                
                                                
            };
            return View("AddNewCourse", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Course course)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new CourseFormViewModel()
                {
                    Course = course,
                    CTypes = _context.CTypes.ToList(),
                    DayInWeeks = _context.DayInWeeks.ToList(),
                    Genres = _context.Genres.ToList(),
                    Levels=_context.Levels.ToList(),
                    Rooms=_context.Rooms.ToList(),
                    Semesters=_context.Semesters.ToList()
                };
                return View("AddNewCourse", viewModel);
            }
            if (course.Id == null)
            {
                //course.Id = 0;
                _context.Courses.Add(course);
            }
            else
            {
                //mapper.map(course,courseInDb)
                var courseInDb = _context.Courses.Single(c => c.Id == course.Id);
                courseInDb.Name = course.Name;
                courseInDb.ClassDuration = course.ClassDuration;
                courseInDb.Hour = course.Hour;
                courseInDb.LevelId = course.LevelId;
                courseInDb.RoomId = course.RoomId;
                courseInDb.SemesterId = course.SemesterId;
                courseInDb.Year = course.Year;
                courseInDb.BeginDate = course.BeginDate;
                courseInDb.EndDate = course.EndDate;
                courseInDb.CTypeId = course.CTypeId;
                courseInDb.DayInWeekId = course.DayInWeekId;
                courseInDb.GenreId = course.GenreId;
                courseInDb.Times = course.Times;
                courseInDb.BeginTime = course.BeginTime;
                courseInDb.EndTime = course.EndTime;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Courses");
        }

        public ActionResult Edit(int id)
        {
            var course = _context.Courses.SingleOrDefault(c => c.Id == id);
            if (course == null)
                return HttpNotFound();
            var viewModel = new CourseFormViewModel
            {
                Course = course,
                Genres = _context.Genres.ToList(),
                CTypes = _context.CTypes.ToList(),
                Levels = _context.Levels.ToList(),
                Rooms = _context.Rooms.ToList(),
                DayInWeeks=_context.DayInWeeks.ToList(),
                Semesters=_context.Semesters.ToList()              
            };
            return View("AddNewCourse", viewModel);
        }
    } 
}