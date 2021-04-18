using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using C4DEnterpriseSys_ver1.Models;
using System.Data.Entity;


namespace C4DEnterpriseSys_ver1.Controllers
{
    

    public class PeopleController : Controller
    {
        private ApplicationDbContext _context;

        public PeopleController()
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

        [Authorize(Roles = RoleName.CanManageCourses)]
        public ActionResult AddNewPerson()
        {
            var genders = _context.Genders.ToList();
            var roles = _context.Roles.ToList();
            var courses = _context.Courses.ToList();
            var viewModel = new PersonFormViewModel
            {
                Genders = genders,
                Roles = roles,
                Courses = courses               
            };

            return View("AddNewPerson", viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Person person)
        {
            if (!ModelState.IsValid)
            {
                var viewModel = new PersonFormViewModel()
                {
                    Person = person,
                    Courses = _context.Courses.ToList(),
                    Genders = _context.Genders.ToList(),
                    Roles = _context.Roles.ToList()
                };
                return View("AddNewPerson", viewModel);
            }
            if (person.Id == null)
            {
                //person.Id = 0;
                _context.People.Add(person);
            }
            else
            {
                //mapper.map(customer,customerInDb)
                var personInDb = _context.People.Single(p => p.Id == person.Id);
                personInDb.Name = person.Name;
                personInDb.Birthdate = person.Birthdate;
                personInDb.IsPremium = person.IsPremium;
                personInDb.Mobile = person.Mobile;
                personInDb.PostalCode = person.PostalCode;
                personInDb.RoleId = person.RoleId;
                personInDb.GenderId = person.GenderId;
                personInDb.CourseId = person.CourseId;
                personInDb.Email = person.Email;
                personInDb.Address = person.Address;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "People");
        }

        public ActionResult Edit(int id)
        {
            var person= _context.People.SingleOrDefault(p => p.Id == id);
            if (person == null)
                return HttpNotFound();
            var viewModel = new PersonFormViewModel
            {
                Person = person,
                Courses = _context.Courses.ToList(),
                Genders = _context.Genders.ToList(),
                Roles =_context.Roles.ToList()
            };
            return View("AddNewPerson", viewModel);
        }
    }
}