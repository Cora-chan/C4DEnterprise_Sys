using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using C4DEnterpriseSys_ver1.Models;

namespace C4DEnterpriseSys_ver1.ViewModels
{
    public class CourseFormViewModel
    {
        public Course Course { get; set; }
        public IEnumerable<Room> Rooms { get; set; }
        public IEnumerable<Level> Levels { get; set; }
        public IEnumerable<Genre> Genres { get; set; }
        public IEnumerable<Semester> Semesters { get; set; }
        public IEnumerable <ClassType> CTypes { get; set; }
        public IEnumerable<DayInWeek> DayInWeeks { get; set; }

    }
}