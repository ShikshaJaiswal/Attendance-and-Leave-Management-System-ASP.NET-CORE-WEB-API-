using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.UI.Models;
using ALMS.UI.Services;

namespace ALMS.UI.Controllers
{
    public class ProjectAllocationController : Controller
    {
        public ProjectAllocationService projectallocationservice = null;
        public ProjectAllocationController()
        {
            this.projectallocationservice = new ProjectAllocationService();
        }
        [Route("Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("GetProjectAllocations")]
        public IActionResult ProjectAllocationIndex()
        {
            List<TrprojectAllocation> list = projectallocationservice.GetProjectAllocationDetails();
            return View(list);
        }

        [Route("ProjectAllocationDetailsByID/{AllocationId}")]
        public IActionResult ProjectAllocationDetails(int AllocationId)
        {
            TrprojectAllocation trprojectAllocation = projectallocationservice.GetProjectAllocationDetailsById(AllocationId);
            return View(trprojectAllocation);
        }

        [HttpGet]
        [Route("AddAllocateProjectAllocation")]
        public IActionResult AddAllocateProjectAllocation()
        {
            return View();
        }
        [HttpPost]
        [Route("AddAllocateProjectAllocation")]
        public IActionResult AddAllocateProjectAllocation(TrprojectAllocation trProjectAllocation)
        {
            if (ModelState.IsValid)
            {
                projectallocationservice.AddAllocateProjectAllocation(trProjectAllocation);
                return RedirectToAction("ProjectAllocationIndex");
            }
            else
            {
                Console.WriteLine("else");
                return View();
            }
        }

        [HttpDelete]
        [Route("DeleteProjectAllocationDetails/{ProjectId}")]
        public IActionResult DeleteProjectAllocationDetails(int ProjectId)
        {
            projectallocationservice.DeleteProjectAllocationDetails(ProjectId);
            return RedirectToAction("ProjectAllocationDetails");
        }
        [HttpGet]
        [Route("EditProjectAllocationDetails")]
        public IActionResult EditProjectAllocationDetails(int AllocationId)
        {
            TrprojectAllocation trprojectAllocation = projectallocationservice.GetProjectAllocationDetailsById(AllocationId);
            return View(trprojectAllocation);
        }
        [HttpPost]
        [Route("EditProjectAllocationDetails")]
        public IActionResult EditProjectAllocationDetails(TrprojectAllocation trprojectAllocation)
        {
            if (ModelState.IsValid)
            {
                projectallocationservice.EditProjectAllocationDetails(trprojectAllocation);
                return RedirectToAction("ProjectAllocationIndex");
            }
            else
                return View();
        }
    }
}
