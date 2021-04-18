using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace C4DEnterpriseSys_ver1.Models
{
    public class SignIn
    {
        public int Id { get; set; }

       
        [Required]
        public Person Person { get; set; }

        [Required]
        public Course Course { get; set; }

        public DateTime DateSignIn { get; set; }
    }
}