using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;
using ALMS.API.Services;

namespace ALMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectAllocationController : ControllerBase
    {
        private ProjectAllocationService projectallocationservice = null;

        public ProjectAllocationController()
        {
            this.projectallocationservice = new ProjectAllocationService();
        }
        [Route("GetProjectAllocationDetails")]
        [HttpGet]
        public IActionResult GetProjectAllocationDetails()
        {
            try
            {
                List<TrprojectAllocation> list = projectallocationservice.GetProjectAllocationDetails();
                return Ok(list);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Route("GetProjectAllocationDetailsById/{AllocationId}")]
        [HttpGet]
        public IActionResult GetProjectAllocationDetailsById(int AllocationId)
        {
            try
            {
                TrprojectAllocation trprojectAllocation = projectallocationservice.GetProjectAllocationDetails(AllocationId);
                return Ok(trprojectAllocation);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        //[Route("EmployeeMenu/{EmployeeId}")]
        //[HttpGet]
        //public IActionResult EmployeeMenu(long EmployeeId)
        //{
        //    try
        //    {
        //        List<TrprojectAllocation> list = projectallocationservice.EmployeeMenu(EmployeeId);
        //        return Ok(list);
        //    }
        //    catch (Exception ex)
        //    {
        //        return NotFound(ex.Message);
        //    }
        //}
        [Route("AllocateProjectAllocation")]
        [HttpPost]
        public IActionResult AllocateProjectAllocation(TrprojectAllocation trProjectAllocation)
        {
            try
            {
                projectallocationservice.AllocateProjectAllocation(trProjectAllocation);
                return Ok("Project Allocated");
            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }

        }
        [Route("UpdateProjectAllocation")]
        [HttpPut]
        public IActionResult UpdateProjectAllocation(TrprojectAllocation trprojectAllocation)
        {
            try
            {
                projectallocationservice.UpdateProjectAllocation(trprojectAllocation);
                return Ok("Record Updated");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Route("DeleteProjectAllocation/{AllocationId}")]
        [HttpDelete]
        public IActionResult DeleteProjectAllocation(int AllocationId)
        {
            try
            {
                projectallocationservice.DeleteProjectAllocation(AllocationId);
                return Ok("Record Deleted");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
