using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using C4DEnterpriseSys_ver1.Models;

namespace C4DEnterpriseSys_ver1.Dtos
{
    public class PersonDto
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        
        public DateTime Birthdate { get; set; }

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        public int Mobile { get; set; }    
        
        [Required]
        public byte RoleId { get; set; }

        public RoleDto Role { get; set; }
        
        [Required]
        public byte GenderId { get; set; }
        public GenderDto Gender { get; set; }

        [Required]
        public string Address { get; set; }

        [Required]
        public int PostalCode { get; set; }

        public bool IsPremium { get; set; }

        [Required]
        public int CourseId { get; set; }
        public CourseDto Course { get; set; }
    }
}