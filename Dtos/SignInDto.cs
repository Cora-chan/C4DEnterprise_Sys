using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using C4DEnterpriseSys_ver1.Models;
using System.ComponentModel.DataAnnotations;

namespace C4DEnterpriseSys_ver1.Dtos
{
    public class SignInDto
    {
        public int Id { get; set; }

        [Required]
        public int Person_Id { get; set; }

        public PersonDto Person { get; set; }

        [Required]
        public int Course_Id { get; set; }

        public CourseDto Course { get; set; }

        public DateTime DateSignIn { get; set; }
    }
}