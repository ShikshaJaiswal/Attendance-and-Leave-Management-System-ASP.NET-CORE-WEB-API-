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
    public class AttendanceRequestController : ControllerBase
    {
        private AttendanceRequestService attendanceRequestService = null;
        public AttendanceRequestController()
        {
            this.attendanceRequestService = new AttendanceRequestService();
        }
        [Route("GetAllAttendance")]
        [HttpGet]
        public IActionResult GetAllTrAttendanceDetails()
        {
            try
            {
                List<TrattendanceDetail> list = attendanceRequestService.GetTrAttendanceDetails();
                return Ok(list);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("GetByAttendanceId/{AttendanceId}")]
        [HttpGet]
        public IActionResult GetByAttendanceId(int AttendanceId)
        {
            try
            {
                TrattendanceDetail trAttendanceDetail = attendanceRequestService.GetTrAttendanceDetail(AttendanceId);
                return Ok(trAttendanceDetail);
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }


        [Route("AddAttendanceRequest")]
        [HttpPost]
        public IActionResult AddTrAttendanceDetail(TrattendanceDetail trAttendanceDetail)
        {
            try
            {
                attendanceRequestService.AddTrAttendanceDetail(trAttendanceDetail);
                return Ok("Record Added");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("UpdateAttendanceRequest")]
        [HttpPut]
        public IActionResult UpdateTrAttendanceDetail(TrattendanceDetail trAttendanceDetail)
        {
            try
            {
                attendanceRequestService.UpdateTrAttendanceDetail(trAttendanceDetail);
                return Ok("Record Updated");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("DeleteAttendance/{AttendanceId}")]
        [HttpDelete]
        public IActionResult DeleteTrAttendanceDetail(int AttendanceId)
        {
            try
            {
                attendanceRequestService.DeleteTrAttendanceDetail(AttendanceId);
                return Ok("Record Deleted");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
