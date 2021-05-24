using ALMS.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;

namespace ALMS.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        private ProjectService projectService = null;

        public ProjectController()
        {
            this.projectService = new ProjectService();
        }
        [Route("GetAllProject")]
        [HttpGet]
        public IActionResult GetAllProject()
        {
            try
            {
                List<MsprojectDetail> list = projectService.GetProject();
                return Ok(list);

            }
            catch (Exception)
            {
                throw;
            }
        }
        [Route("GetByProjectId/{ProjectId}")]
        [HttpGet]
        public IActionResult GetByProjectId(int ProjectId)
        {
            try
            {
                MsprojectDetail msProjectDetail = projectService.GetProject(ProjectId);
                return Ok(msProjectDetail);

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Route("AddProject")]
        [HttpPost]
        public IActionResult AddProject(MsprojectDetail msProjectDetail)
        {
            try
            {
                projectService.AddProject(msProjectDetail);
                Console.WriteLine("OK record added");
                return Ok("Record Added");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Route("UpdateProject")]
        [HttpPut]
        public IActionResult UpdateProject(MsprojectDetail msProjectDetail)
        {
            try
            {
                projectService.UpdateProject(msProjectDetail);
                return Ok("Record Updated");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
        [Route("DeleteProject/{ProjectId}")]
        [HttpDelete]
        public IActionResult DeleteProject(int ProjectId)
        {
            try
            {
                projectService.DeleteProject(ProjectId);
                return Ok("Record Deleted");

            }
            catch (Exception ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
