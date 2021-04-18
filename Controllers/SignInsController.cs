using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using C4DEnterpriseSys_ver1.Models;
using System.Data.Entity;
using C4DEnterpriseSys_ver1.ViewModels;

namespace C4DEnterpriseSys_ver1.Controllers
{
    public class SignInsController : Controller
    {
        // GET: SignIns
       
        public ActionResult New()
        {
            return View();
        }

       

        public ViewResult Index()
        {
            if (User.IsInRole(RoleName.CanManageCourses))
                return View("Index");
            else
                return View("ReadOnlyList");
        }


    }      
}