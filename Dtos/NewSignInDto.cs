using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace C4DEnterpriseSys_ver1.Dtos
{
    public class NewSignInDto
    {
        public int PersonId { get; set; }
        public List<int> CourseIds { get; set; }
    }
}