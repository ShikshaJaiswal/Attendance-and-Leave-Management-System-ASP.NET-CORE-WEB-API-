using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Services;
using ALMS.API.Models;

namespace ALMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private EmployeeService employeeService = null;

        public EmployeeController()
        {
            this.employeeService = new EmployeeService();
        }
        [Route("GetAllEmployee")]
        [HttpGet]
        public IActionResult GetAllEmployee()
        {
            try
            {
                List<MsemployeeDetail> list = employeeService.GetEmployee();
                return Ok(list);

            }
            catch (Exception)
            {
                throw ;
            }
        }
        [Route("GetByEmployeeId/{EmployeeId}")]
        [HttpGet]
        public IActionResult GetByEmployeeId(long EmployeeId)
        {
            try
            {
                MsemployeeDetail msEmployeeDetail = employeeService.GetEmployee(EmployeeId);
                return Ok(msEmployeeDetail);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Route("AddEmployee")]
        [HttpPost]
        public IActionResult AddEmployee(MsemployeeDetail msEmployeeDetail)
        {
            try
            {
                employeeService.AddEmployee(msEmployeeDetail);
                return Ok("Record Added");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Route("UpdateEmployee")]
        [HttpPut]
        public IActionResult UpdateEmployee(MsemployeeDetail msEmployeeDetail)
        {
            try
            {
                employeeService.UpdateEmployee(msEmployeeDetail);
                return Ok("Record Updated");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }

        [Route("DeleteEmployee/{EmployeeId}")]
        [HttpDelete]
        public IActionResult DeleteEmployee(long EmployeeId)
        {
            try
            {
                employeeService.DeleteEmployee(EmployeeId);
                return Ok("Record Deleted");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
