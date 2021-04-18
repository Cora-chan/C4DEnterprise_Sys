using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace C4DEnterpriseSys_ver1.Models
{
    public class Course
    {   
        
        public int? Id { get; set; }

        
        [StringLength (255)]
        [Required]
        public string Name { get; set; }

       
        
        public Semester Semester { get; set; }

        
        [Display(Name = "Semester")]
        [Required]
        public byte SemesterId { get; set; }

        [Required]
        public int Year { get; set; }

        
        public DayInWeek DayInWeek { get; set; }

        [Required]
        [Display(Name = "Day in Week")]
        public byte DayInWeekId { get; set; }

        [Required]
        public int Times { get; set; }

        
        public Level Level { get; set; }

        
        [Display(Name = "Level")]
        [Required]
        public byte LevelId { get; set; }

        
        public Genre Genre { get; set; }

        
        [Display(Name = "Genre")]
        [Required]
        public byte GenreId { get; set; }

        
        public Room Room { get; set; }

        
        [Display(Name = "Room")]
        [Required]
        public byte RoomId { get; set; }

        
        public ClassType CType { get; set; }

        
        [Display(Name = "Class Type")]
        [Required]
        public byte CTypeId { get; set; }


        [Required]
        public int Hour { get; set; }


        [Required]
        public int ClassDuration { get; set; }


        [Display(Name = "Date format 'MM/DD/YYYY'")]
        [Required]
        public DateTime BeginDate { get; set; }


        [Display(Name = "Date format 'MM/DD/YYYY'")]
        [Required]
        public DateTime EndDate { get; set; }


        [Display(Name = "Time format 'HHMM'")]
        [Required]
        public int BeginTime { get; set; }


        [Display(Name = "Time format 'HHMM'")]
        [Required]
        public int EndTime { get; set; }

       


    }
}