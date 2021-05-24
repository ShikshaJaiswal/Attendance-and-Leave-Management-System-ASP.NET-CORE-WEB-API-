using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.API.Services
{
    public class ProjectAllocationService : IProjectAllocationService
    {
        private ProjectAllocationRepository repository;
        public ProjectAllocationService()
        {
            this.repository = new ProjectAllocationRepository();
        }
        public List<TrprojectAllocation> GetProjectAllocationDetails()
        {
            return repository.GetProjectAllocationDetails();
        }
        public TrprojectAllocation GetProjectAllocationDetails(int AllocationId)
        {
            return repository.GetProjectAllocationDetails(AllocationId);
        }
        public bool AllocateProjectAllocation(TrprojectAllocation trProjectAllocation)
        {
            return repository.AllocateProjectAllocation(trProjectAllocation);
        }
        public bool DeleteProjectAllocation(int AllocationId)
        {
            return repository.DeleteProjectAllocation(AllocationId);
        }
        public bool UpdateProjectAllocation(TrprojectAllocation trprojectAllocation)
        {
            return repository.UpdateProjectAllocation(trprojectAllocation);
        }
    }
}
