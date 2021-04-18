using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using C4DEnterpriseSys_ver1.Models;
using C4DEnterpriseSys_ver1.Dtos;
using AutoMapper;
using System.Data.Entity;


namespace C4DEnterpriseSys_ver1.Controllers.Api
{
    public class PeopleController : ApiController
    {
        private ApplicationDbContext _context;

        public PeopleController()
        {
            _context = new ApplicationDbContext();
        }

        //GET /api/people
        public IHttpActionResult GetPeople(string query = null)
        {

            //loop 1 for role
            var peopleQuery = _context.People
                .Include(p => p.Role);

            if (!String.IsNullOrWhiteSpace(query))
                peopleQuery = peopleQuery.Where(p => p.Name.Contains(query));

            var personDtos = peopleQuery
                .ToList()
                .Select(Mapper.Map<Person, PersonDto>);

            //loop 2 for gender
            peopleQuery = _context.People
               .Include(p => p.Gender);

            if (!String.IsNullOrWhiteSpace(query))
                peopleQuery = peopleQuery.Where(p => p.Name.Contains(query));

            personDtos = peopleQuery
                .ToList()
                .Select(Mapper.Map<Person, PersonDto>);

            //loop 3 for  course
            peopleQuery = _context.People
               .Include(p => p.Course);

            if (!String.IsNullOrWhiteSpace(query))
                peopleQuery = peopleQuery.Where(p => p.Name.Contains(query));

            personDtos = peopleQuery
                .ToList()
                .Select(Mapper.Map<Person, PersonDto>);



            return Ok(personDtos);

         //   var personDtos = _context.People
           //     .Include(p => p.Role)
             //   .ToList()
           //     .Select(Mapper.Map<Person, PersonDto>);
           // personDtos = _context.People
            //.Include(p => p.Course)
            //.ToList()
            //.Select(Mapper.Map<Person, PersonDto>);
           // personDtos = _context.People
           // .Include(p => p.Gender)
           // .ToList()
           // .Select(Mapper.Map<Person, PersonDto>);

           // return Ok(personDtos);       
        }

        //GET /api/people/1
        public IHttpActionResult GetPerson(int id)
        {
            var person = _context.People.SingleOrDefault(c => c.Id == id);

            if (person == null)
                return NotFound();

            return Ok(Mapper.Map<Person,PersonDto>(person));
        }

        //POST /api/people
        [HttpPost]
        public IHttpActionResult CreatePerson (PersonDto personDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var person = Mapper.Map<PersonDto, Person>(personDto);
            _context.People.Add(person);
            _context.SaveChanges();

            personDto.Id = person.Id;

            return Created(new Uri(Request.RequestUri + "/"+person.Id),personDto);
        }

        //PUT /api/people/1
        [HttpPut]
        public IHttpActionResult UpdatePerson (int id,PersonDto personDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var personInDb = _context.People.SingleOrDefault(p => p.Id == id);

            if (personInDb == null)
                return NotFound();

            Mapper.Map(personDto, personInDb);
            _context.SaveChanges();

            return Ok();
        }

        //DELETE /api/people/1
        [HttpDelete]
        public IHttpActionResult DeletePerson (int id)
        {
            var personInDb = _context.People.SingleOrDefault(c => c.Id == id);

            if (personInDb == null)
                return NotFound();

            _context.People.Remove(personInDb);
            _context.SaveChanges();

            return Ok();

        }
    }
}
