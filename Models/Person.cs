using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace C4DEnterpriseSys_ver1.Models
{
    public class Person
    {
        
        public int? Id { get; set; }
        

        [Required]
        [StringLength(255)]
        public string Name { get; set; }


        //[Display(Name = "Id")]
        // public int SchoolId { get; set; }

        [Display(Name = "Birthdate MM/DD/YYYY")]
        public DateTime Birthdate { get; set; }


        
        [EmailAddress]
        [Required]
        public string Email { get; set; }

        [Required]
        [MinLength(4)]
        [MaxLength(15)]
        public string Mobile { get; set; }

       
        public Role Role { get; set; }

        
        [Display(Name = "Role")]
        [Required]
        public byte RoleId { get; set; }

        
        public Gender Gender { get; set; }

        
        [Display(Name = "Gender")]
        [Required]
        public byte GenderId { get; set; }

        
        [Required]
        public string Address { get; set; }

        [Required]
        public string PostalCode { get; set; }

        
        public bool IsPremium { get; set; }

        
        public Course Course { get; set; }
 
        
        [Display(Name = "Course")]
        [Required]
        public int CourseId { get; set; }


    }
}