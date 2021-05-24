using ALMS.UI.Models;
using ALMS.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALMS.UI.Controllers
{
    public class EmployeeController : Controller
    {
        public EmployeeService employeeService = null;
        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }


        [Route("GetAllEmployee")]
        public IActionResult EmployeeIndex()
        {
            List<MsemployeeDetail> list = employeeService.GetEmployee();
            return View(list);
        }


        [Route("EmployeeDetails/{EmployeeId}")]
        public IActionResult EmployeeDetails(long EmployeeId)
        {
            MsemployeeDetail msEmployeeDetail = employeeService.GetByEmployeeId(EmployeeId);
            return View(msEmployeeDetail);
        }



        [HttpGet]
        [Route("AddEmployee")]
        public IActionResult CreateEmployee()
        {
            return View();
        }

        [HttpPost]
        [Route("AddEmployee")]
        public IActionResult CreateEmployee(MsemployeeDetail msEmployeeDetail)
        {
            if (ModelState.IsValid)
            {
                employeeService.AddEmployee(msEmployeeDetail);               
                return RedirectToAction("EmployeeIndex");
            }
            else
            {
                
                return View();
            }
        }


        //[HttpGet]
        //[Route("DeleteEmployee")]
        //public IActionResult DeleteEmployee(long EmployeeId)
        //{
        //    MsemployeeDetail msemployeeDetail = employeeService.GetByEmployeeId(EmployeeId);

        //    return View("DeleteEmployee");
        //}

        //[HttpPost]
        //[Route("DeleteEmployee")]
        //public IActionResult DeleteEmployee(MsemployeeDetail msEmployeeDetail)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        employeeService.DeleteEmployee(msEmployeeDetail);
        //        return RedirectToAction("EmployeeIndex");
        //    }
        //    else
        //        return View();
        //}



        [HttpGet]
        [Route("EditEmployee")]
        public IActionResult EditEmployee(long EmployeeId)
        {
            MsemployeeDetail msEmployeeDetail = employeeService.GetByEmployeeId(EmployeeId);
            return View(msEmployeeDetail);
        }
        [HttpPost]
        [Route("EditEmployee")]
        public IActionResult EditEmployee(MsemployeeDetail msEmployeeDetail)
        {
            if (ModelState.IsValid)
            {
                employeeService.UpdateEmployee(msEmployeeDetail);
                return RedirectToAction("EmployeeIndex");
            }
            else
                return View();
        }
    }
}
