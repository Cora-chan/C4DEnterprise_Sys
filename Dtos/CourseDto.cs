using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace C4DEnterpriseSys_ver1.Dtos
{
    public class CourseDto
    {

        public int? Id { get; set; }


        [StringLength(255)]
        [Required]
        public string Name { get; set; }

        [Required]
        public byte SemesterId { get; set; }

        public SemesterDto Semester { get; set; }

        [Required]
        public int Year { get; set; }


        [Required]
        public byte DayInWeekId { get; set; }

        public DayInWeekDto DayInWeek { get; set; }

        [Required]
        public int Times { get; set; }


        [Required]
        public byte LevelId { get; set; }
        public LevelDto Level { get; set; }

        [Required]
        public byte GenreId { get; set; }
        public GenreDto Genre { get; set; }


        [Required]
        public byte RoomId { get; set; }
        public RoomDto Room { get; set; }



        [Required]
        public byte CTypeId { get; set; }
        public ClassTypeDto CType { get; set; }


        [Required]
        public int Hour { get; set; }


        [Required]
        public int ClassDuration { get; set; }


        [Required]
        public DateTime BeginDate { get; set; }


        [Required]
        public DateTime EndDate { get; set; }



        [Required]
        public int BeginTime { get; set; }


        [Required]
        public int EndTime { get; set; }


    }
}