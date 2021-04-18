using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using C4DEnterpriseSys_ver1.Models;

namespace C4DEnterpriseSys_ver1
{
    public class PersonFormViewModel
    {
        public Person Person { get; set; }
        public IEnumerable<Gender> Genders { get; set; }
        public IEnumerable<Role> Roles { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        
    }
}