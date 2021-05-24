using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;
using ALMS.API.Services;
using ALMS.API.Repositories;

namespace ALMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeaveRequestController : ControllerBase
    {
        private LeaveRequestService leaveRequestService = null;
        public LeaveRequestController()
        {
            this.leaveRequestService = new LeaveRequestService();
        }
        [Route("GetAllLeave")]
        [HttpGet]
        public IActionResult GetAllTrLeaveRequestDetails()
        {
            try
            {
                List<TrleaveRequestDetail> list = leaveRequestService.GetTrLeaveRequestDetails();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("GetByLeaveId/{LeaveRequestId}")]
        [HttpGet]
        public IActionResult GetByLeaveId(int LeaveRequestId)
        {
            try
            {
                TrleaveRequestDetail trLeaveRequestDetail = leaveRequestService.GetTrLeaveRequestDetail(LeaveRequestId);
                return Ok(trLeaveRequestDetail);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [Route("AddLeaveRequest")]
        [HttpPost]
        public IActionResult AddTrLeaveRequestDetail(TrleaveRequestDetail trLeaveRequestDetail)
        {
            try
            {
                leaveRequestService.AddTrLeaveRequestDetail(trLeaveRequestDetail);
                return Ok("Record Added");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("UpdateLeaveRequest")]
        [HttpPut]
        public IActionResult UpdateTrLeaveRequestDetail(TrleaveRequestDetail trLeaveRequestDetail)
        {
            try
            {
                leaveRequestService.UpdateTrLeaveRequestDetail(trLeaveRequestDetail);
                return Ok("Record Updated");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("DeleteLeaveRequest/{LeaveRequestId}")]
        [HttpDelete]
        public IActionResult DeleteTrLeaveRequestDetail(int LeaveRequestId)
        {
            try
            {
                leaveRequestService.DeleteTrLeaveRequestDetail(LeaveRequestId);
                return Ok("Record Deleted");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
