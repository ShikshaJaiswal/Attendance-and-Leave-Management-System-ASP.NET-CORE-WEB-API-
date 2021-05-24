using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.UI.Services;
using ALMS.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;

namespace ALMS.UI.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        
        public ActionResult Login(MsuserRegistration msuserRegistration)
        {
            try
            {
                using (Sprint2ALMSContext db = new Sprint2ALMSContext())
                {
                    var user = db.MsuserRegistrations.Single(u => u.UserName == msuserRegistration.UserName && u.Password == msuserRegistration.Password && u.EmployeeId== msuserRegistration.EmployeeId && u.UserType== msuserRegistration.UserType);
                    if (user != null && msuserRegistration.UserType == "ASE")
                    {
                        HttpContext.Session.SetString("UserName", user.UserName);
                        HttpContext.Session.SetString("Password", user.Password);
                        return RedirectToAction("GEmployeePortal", new { user.UserName, user.EmployeeId });
                    }
                    else if (user != null && msuserRegistration.UserType == "Manager")
                    {
                        HttpContext.Session.SetString("UserName", user.UserName);
                        HttpContext.Session.SetString("Password", user.Password);
                        return RedirectToAction("ManagerPortal", new { user.UserName, user.EmployeeId  });
                    }
                    else
                    {
                        HttpContext.Session.SetString("UserName", user.UserName);
                        HttpContext.Session.SetString("Password", user.Password);
                        return RedirectToAction("AdminPortal", new { user.UserName, user.EmployeeId});

                    }
                }
            }
            catch
            {
                ViewData["errMsg"] = "Invalid Credentials";
                return View();
            }
        }

      
        [HttpGet]
        [Route("GEmployeePortal/{UserName}/{EmployeeId}")]
        public ActionResult GEmployeePortal(string UserName, long EmployeeId)
        {

            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.Message1 = UserName;
                ViewBag.Message2 = EmployeeId;
                               
                return View();
            }
            else
                return RedirectToAction("Privacy");
        }
        /*public ActionResult LoginFailed()
        {
        }*/
        
        [HttpGet]
        [Route("ManagerPortal/{UserName}/{EmployeeId}")]
        public ActionResult ManagerPortal(string UserName, long EmployeeId)
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.Message1 = UserName;
                ViewBag.Message2 = EmployeeId;
                return View();
            }
            else
                return RedirectToAction("Privacy");
        }

        
        [HttpGet]
        [Route("AdminPortal/{UserName}/{EmployeeId}")]
        public ActionResult AdminPortal(string UserName, long EmployeeId)
        {
            if (HttpContext.Session.GetString("UserName") != null)
            {
                ViewBag.Message1 = UserName;
                ViewBag.Message2 = EmployeeId;
                return View();
            }
            else
                return RedirectToAction("Privacy");
        }

        
        public ActionResult ProjectLogin(MsProjectLoginDetail msProjectLoginDetail)
        {
            try
            {
                using (Sprint2ALMSContext db = new Sprint2ALMSContext())
                {
                    var user = db.MsProjectLoginDetails.Single(u => u.ProjectId == msProjectLoginDetail.ProjectId && u.EmployeeId == msProjectLoginDetail.EmployeeId && u.ProjectPassword == msProjectLoginDetail.ProjectPassword);
                    if (user != null)
                    {
                        HttpContext.Session.SetString("ProjectId",Convert.ToString( user.ProjectId));
                        HttpContext.Session.SetString("EmployeeId",Convert.ToString( user.EmployeeId));
                        HttpContext.Session.SetString("ProjectPassword", user.ProjectPassword);
                        return RedirectToAction("ProjectWorkStation", "Project", new { user.ProjectId, user.EmployeeId});
                    }
                   
                    else
                    {
                        throw new Exception("Invalid credentials");

                    }
                }
            }
            catch (Exception e)
            {
                ViewData["errMsg"] = e.Message;
                return View();
            }
        }

    }
}
