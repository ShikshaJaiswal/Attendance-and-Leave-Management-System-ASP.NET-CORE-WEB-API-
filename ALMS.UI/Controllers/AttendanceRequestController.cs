using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.UI.Models;
using ALMS.UI.Services;


namespace ALMS.UI.Controllers
{
    public class AttendanceRequestController : Controller
    {

        public AttendanceRequestService attendanceRequestService = null;
        public AttendanceRequestController()
        {
            attendanceRequestService = new AttendanceRequestService();
        }


        [Route("AdminGetAllAttendance")]
        public IActionResult AttendanceIndexAdmin()
        {
            List<TrattendanceDetail> list = attendanceRequestService.GetTrAttendanceDetails();
            return View(list);
        }
        public IEnumerable<TrattendanceDetail> results { get; set; }
        
        [HttpPost]
        [Route("AdminGetAllAttendance")]
        public IActionResult AttendanceIndexAdmin(DateTime startdate, DateTime enddate)
        {
            results = (from x in attendanceRequestService.GetTrAttendanceDetails() where (x.AttedanceDate >= startdate) && (x.AttedanceDate <= enddate.AddDays(1)) select x) ;
            return View(results.ToList());
        }


        [Route("ManagerGetAllAttendance")]
        public IActionResult AttendanceIndexManager()
        {
            List<TrattendanceDetail> list = attendanceRequestService.GetTrAttendanceDetails();
            return View(list);
        }
        

        [HttpPost]
        [Route("ManagerGetAllAttendance")]
        public IActionResult AttendanceIndexManager(DateTime startdate, DateTime enddate)
        {
            results = (from x in attendanceRequestService.GetTrAttendanceDetails() where (x.AttedanceDate >= startdate) && (x.AttedanceDate <= enddate.AddDays(1)) select x);
            return View(results.ToList());
        }




        [Route("AttendanceDetails/{AttendanceId}")]
        public IActionResult AttendanceDetails(int AttendanceId)
        {
            TrattendanceDetail trAttendanceDetail = attendanceRequestService.GetByAttendanceId(AttendanceId);
            return View(trAttendanceDetail);
        }
        [HttpGet]
        [Route("AddAttendanceRequest")]
        public IActionResult CreateAttendanceRequest()
        {
            return View();
        }
        [HttpPost]
        [Route("AddAttendanceRequest")]
        public IActionResult CreateAttendanceRequest(TrattendanceDetail trAttendanceDetail)
        {
            if (ModelState.IsValid)
            {
                attendanceRequestService.AddAttendanceDetail(trAttendanceDetail);
                return RedirectToAction("ProjectWorkStation", "Project", new { trAttendanceDetail.EmployeeId, trAttendanceDetail.ProjectId });
            }
            else
            {

                return View();
            }
        }
        //[Route("DeleteAttendance/{AttendanceId}")]
        //public IActionResult DeleteAttendance(int AttendanceId)
        //{
        //    attendanceRequestService.DeleteAttendanceDetail(AttendanceId);
        //    return RedirectToAction("AttendanceIndex");
        //}
        [HttpGet]
        [Route("EditAttendanceRequest")]
        public IActionResult EditAttendance(int AttendanceId)
        {
            TrattendanceDetail trAttendanceDetail = attendanceRequestService.GetByAttendanceId(AttendanceId);
            return View(trAttendanceDetail);
        }
        [HttpPost]
        [Route("EditAttendanceRequest")]
        public IActionResult EditAttendance(TrattendanceDetail trAttendanceDetail)
        {
            if (ModelState.IsValid)
            {
                attendanceRequestService.UpdateAttendanceDetail(trAttendanceDetail);
                return RedirectToAction("AttendanceIndexAdmin");
            }
            else
                return View();
        }
    }
}
