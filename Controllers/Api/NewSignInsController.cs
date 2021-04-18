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
    public class NewSignInsController : ApiController
    {
       
            private ApplicationDbContext _context;

            public NewSignInsController()
            {
                _context = new ApplicationDbContext();
            }

            [HttpPost]
        public IHttpActionResult CreateNewSignIn(NewSignInDto newSignIn)
        {
            if (newSignIn.CourseIds.Count == 0)
                return BadRequest("No Ids have been given.");

            var person = _context.People.Single(
                p => p.Id == newSignIn.PersonId);

            var courses = _context.Courses.Where(
                c => newSignIn.CourseIds.Contains(c.Id.Value)).ToList();


            foreach (var course in courses)
            {
               
                var signin = new SignIn
                {
                    Person = person,
                    Course = course,
                    DateSignIn = DateTime.Now
                };

                _context.SignIns.Add(signin);
            }

            _context.SaveChanges();
            return Ok();
        }

        ////GET /api/signin
        public IHttpActionResult GetSignIns()
        {
            var signinDtos = _context.SignIns
                .Include(s => s.Course)
                .ToList()
                .Select(Mapper.Map<SignIn, SignInDto>);

                signinDtos = _context.SignIns
                .Include(s => s.Person)
                .ToList()
                .Select(Mapper.Map<SignIn, SignInDto>);


            return Ok(signinDtos);
                
        }

        //DELETE /api/people/1
        [HttpDelete]
        public IHttpActionResult DeleteSignIn(int id)
        {
            var signinInDb = _context.SignIns.SingleOrDefault(c => c.Id == id);

            if (signinInDb == null)
                return NotFound();

            _context.SignIns.Remove(signinInDb);
            _context.SaveChanges();

            return Ok();
        }

    }
}
