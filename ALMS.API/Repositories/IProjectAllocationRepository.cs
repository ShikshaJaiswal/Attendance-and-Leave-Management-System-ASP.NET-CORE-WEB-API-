using ALMS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALMS.API.Repositories
{
    interface IProjectAllocationRepository
    {
        List<TrprojectAllocation> GetProjectAllocationDetails();
        TrprojectAllocation GetProjectAllocationDetails(int AllocationId);
        bool AllocateProjectAllocation(TrprojectAllocation trProjectAllocation);
        bool DeleteProjectAllocation(int AllocationId);
        bool UpdateProjectAllocation(TrprojectAllocation trprojectAllocation);
    }
}
