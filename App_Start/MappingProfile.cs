using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using C4DEnterpriseSys_ver1.Dtos;
using C4DEnterpriseSys_ver1.Models;

namespace C4DEnterpriseSys_ver1.App_Start
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            //domain to dto
            Mapper.CreateMap<Person, PersonDto>();
            Mapper.CreateMap<Course, CourseDto>();
            Mapper.CreateMap<Role, RoleDto>();
            Mapper.CreateMap<Gender, GenderDto>();
            Mapper.CreateMap<DayInWeek, DayInWeekDto>();
            Mapper.CreateMap<Semester, SemesterDto>();
            Mapper.CreateMap<Level, LevelDto>();
            Mapper.CreateMap<Genre, GenreDto>();
            Mapper.CreateMap<ClassType, ClassTypeDto>();
            Mapper.CreateMap<Room, RoomDto>();
            Mapper.CreateMap<SignIn, SignInDto>();

            //dto to domain
            Mapper.CreateMap<PersonDto, Person>().ForMember(p => p.Id, opt => opt.Ignore());
            Mapper.CreateMap<CourseDto, Course>().ForMember(c => c.Id, opt => opt.Ignore());
        }
    }
}