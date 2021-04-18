using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using C4DEnterpriseSys_ver1.Dtos;
using C4DEnterpriseSys_ver1.Models;
using AutoMapper;
using System.Data.Entity;

namespace C4DEnterpriseSys_ver1.Controllers.Api
{
    public class CoursesController : ApiController
    {
        private ApplicationDbContext _context;

        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/course
        public IHttpActionResult GetCourses(string query=null)
        {
            //dayinweek
            var coursesQuery = _context.Courses
                .Include(c => c.DayInWeek);

            if (!String.IsNullOrWhiteSpace(query))
                coursesQuery = coursesQuery.Where(p => p.Name.Contains(query));

            var courseDtos = coursesQuery
                .ToList()
                .Select(Mapper.Map<Course, CourseDto>);

            //ctype
             coursesQuery = _context.Courses
                .Include(c => c.CType);

            if (!String.IsNullOrWhiteSpace(query))
                coursesQuery = coursesQuery.Where(p => p.Name.Contains(query));

                courseDtos = coursesQuery
                .ToList()
                .Select(Mapper.Map<Course, CourseDto>);

            //semester
            coursesQuery = _context.Courses
                .Include(c => c.Semester);

            if (!String.IsNullOrWhiteSpace(query))
                coursesQuery = coursesQuery.Where(p => p.Name.Contains(query));

            courseDtos = coursesQuery
            .ToList()
            .Select(Mapper.Map<Course, CourseDto>);

            //room
            coursesQuery = _context.Courses
                .Include(c => c.Room);

            if (!String.IsNullOrWhiteSpace(query))
                coursesQuery = coursesQuery.Where(p => p.Name.Contains(query));

            courseDtos = coursesQuery
            .ToList()
            .Select(Mapper.Map<Course, CourseDto>);

            //level
            coursesQuery = _context.Courses
                .Include(c => c.Level);

            if (!String.IsNullOrWhiteSpace(query))
                coursesQuery = coursesQuery.Where(p => p.Name.Contains(query));

            courseDtos = coursesQuery
            .ToList()
            .Select(Mapper.Map<Course, CourseDto>);

            //genre
            coursesQuery = _context.Courses
                .Include(c => c.Genre);

            if (!String.IsNullOrWhiteSpace(query))
                coursesQuery = coursesQuery.Where(p => p.Name.Contains(query));

            courseDtos = coursesQuery
            .ToList()
            .Select(Mapper.Map<Course, CourseDto>);

            return Ok(courseDtos);

        }

        //GET /api/courses/1
        public IHttpActionResult GetCourse(int id)
        {
            var course = _context.Courses.SingleOrDefault(c => c.Id == id);

            if (course == null)
                return NotFound();

            return Ok(Mapper.Map<Course, CourseDto>(course));
        }

        //POST /api/courses
        [HttpPost]
        public IHttpActionResult CreateCourse(CourseDto courseDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var course = Mapper.Map<CourseDto, Course>(courseDto);
            _context.Courses.Add(course);
            _context.SaveChanges();

            courseDto.Id = course.Id;

            return Created(new Uri(Request.RequestUri + "/" + course.Id), courseDto);
        }

        //PUT /Api/courses/1
        [HttpPut]
        public IHttpActionResult UpdateCourse(int id, CourseDto courseDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var courseInDb = _context.Courses.SingleOrDefault(p => p.Id == id);

            if (courseInDb == null)
                return NotFound();

            Mapper.Map(courseDto, courseInDb);

            _context.SaveChanges();

            return Ok();
        }

        //DELETE /api/people/1
        [HttpDelete]
        public IHttpActionResult DeleteCourse(int id)
        {
            var courseInDb = _context.Courses.SingleOrDefault(c => c.Id == id);

            if (courseInDb == null)
                return NotFound();

            _context.Courses.Remove(courseInDb);
            _context.SaveChanges();

            return Ok();

        }
    }
}

    

