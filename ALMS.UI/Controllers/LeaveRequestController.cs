using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.UI.Models;
using ALMS.UI.Services;

namespace ALMS.UI.Controllers
{
    public class LeaveRequestController : Controller
    {
        public LeaveRequestService leaveRequestService = null;
        public LeaveRequestController()
        {
            leaveRequestService = new LeaveRequestService();
        }
        [Route("Manager/GetAllLeave")]
        public IActionResult LeaveRequestIndexManager()
        {
            List<TrleaveRequestDetail> list = leaveRequestService.GetLeaveRequestDetails();
            return View(list);
        }

        [Route("Admin/GetAllLeave")]
        public IActionResult LeaveRequestIndexAdmin()
        {
            List<TrleaveRequestDetail> list = leaveRequestService.GetLeaveRequestDetails();
            return View(list);
        }


        [Route("LeaveRequestDetails/{LeaveRequestId}")]
        public IActionResult LeaveRequestDetails(int LeaveRequestId)
        {
            TrleaveRequestDetail trLeaveRequestDetail = leaveRequestService.GetByLeaveId(LeaveRequestId);
            return View(trLeaveRequestDetail);
        }
        [HttpGet]
        [Route("AddLeaveRequest")]
        public IActionResult CreateLeaveRequest()
        {
            return View();
        }
        [HttpPost]
        [Route("AddLeaveRequest")]
        public IActionResult CreateLeaveRequest(TrleaveRequestDetail trLeaveRequestDetail)
        {
            if (ModelState.IsValid)
            {
                leaveRequestService.AddLeaveRequest(trLeaveRequestDetail);
                return RedirectToAction("ProjectLogin", "Account");
            }
            else
            {

                return View();
            }
        }
        //[Route("DeleteLeaveRequest/{LeaveRequestId}")]
        //public IActionResult DeleteLeaveRequest(int LeaveRequestId)
        //{
        //    leaveRequestService.DeleteLeaveRequest(LeaveRequestId);
        //    return RedirectToAction("LeaveRequestIndexAdmin");
        //}
        [HttpGet]
        [Route("EditLeaveRequest")]
        public IActionResult EditLeaveRequest(int LeaveRequestId)
        {
            TrleaveRequestDetail trLeaveRequestDetail = leaveRequestService.GetByLeaveId(LeaveRequestId);
            return View(trLeaveRequestDetail);
        }
        [HttpPost]
        [Route("EditLeaveRequest")]
        public IActionResult EditLeaveRequest(TrleaveRequestDetail trLeaveRequestDetail)
        {
            if (ModelState.IsValid)
            {
                leaveRequestService.UpdateLeaveRequest(trLeaveRequestDetail);
                return RedirectToAction("LeaveRequestIndexManager");
            }
            else
                return View();
        }

      
        
    }
}
