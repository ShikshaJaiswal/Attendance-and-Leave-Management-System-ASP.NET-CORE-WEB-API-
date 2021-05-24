using ALMS.UI.Models;
using ALMS.UI.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALMS.UI.Controllers
{
    public class ProjectController : Controller
    {
        public ProjectService projectService = null;
        public ProjectController()
        {
            projectService = new ProjectService();
        }
        [Route("GetAllProjects")]
        public IActionResult ProjectIndex()
        {
            List<MsprojectDetail> list = projectService.GetProject();
            return View(list);
        }


        [Route("ProjectDetails/{ProjectId}")]
        public IActionResult ProjectDetails(int ProjectId)
        {
            MsprojectDetail project = projectService.GetByProjectId(ProjectId);
            return View(project);
        }
        [HttpGet]
        [Route("AddProject")]
        public IActionResult CreateProject()
        {
            return View();
        }
        [HttpPost]
        [Route("AddProject")]
        public IActionResult CreateProject(MsprojectDetail project)
        {
            if (ModelState.IsValid)
            {
                projectService.AddProject(project);
                return RedirectToAction("ProjectIndex");
            }
            else
            {
                return View();
            }
        }
        //[Route("DeleteProject/{ProjectId}")]
        //public IActionResult DeleteProject(int ProjectId)
        //{
        //    projectService.DeleteProject(ProjectId);
        //    return RedirectToAction("ProjectIndex");
        //}
        [HttpGet]
        [Route("EditProject")]
        public IActionResult EditProject(int ProjectId)
        {
            MsprojectDetail project = projectService.GetByProjectId(ProjectId);
            return View(project);
        }
        [HttpPost]
        [Route("EditProject")]
        public IActionResult EditProject(MsprojectDetail project)
        {
            if (ModelState.IsValid)
            {
                projectService.UpdateProject(project);
                return RedirectToAction("ProjectIndex");
            }
            else
                return View();
        }

        [HttpGet]
        [Route("ProjectWorkStation")]
        public IActionResult ProjectWorkStation(int ProjectId, long EmployeeId)
        {
            ViewBag.Message1 = ProjectId;
            ViewBag.Message2 = EmployeeId;
            

            return View();
        }
    }
}
