using ALMS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALMS.API.Repositories
{
    public class ProjectAllocationRepository : IProjectAllocationRepository
    {
        private Sprint2ALMSContext context;

        public ProjectAllocationRepository()
        {
            this.context = new Sprint2ALMSContext();
        }
        public List<TrprojectAllocation> GetProjectAllocationDetails()
        {
            return context.TrprojectAllocations.ToList();
        }
        public TrprojectAllocation GetProjectAllocationDetails(int AllocationId)
        {
            return context.TrprojectAllocations.Find(AllocationId);
        }

        public bool AllocateProjectAllocation(TrprojectAllocation trProjectAllocation)
        {
            context.TrprojectAllocations.Add(trProjectAllocation);
            context.SaveChanges();
            return true;
        }
        public bool DeleteProjectAllocation(int AllocationId)
        {
            TrprojectAllocation trprojectAllocation = context.TrprojectAllocations.Find(AllocationId);
            context.TrprojectAllocations.Remove(trprojectAllocation);
            context.SaveChanges();
            return true;
        }
        public bool UpdateProjectAllocation(TrprojectAllocation trprojectAllocation)
        {
            context.TrprojectAllocations.Update(trprojectAllocation);
            context.SaveChanges();
            return true;
        }
    }
}
