using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;

namespace ALMS.API.Services
{
    interface IProjectAllocationService
    {
        List<TrprojectAllocation> GetProjectAllocationDetails();
        TrprojectAllocation GetProjectAllocationDetails(int AllocationId);
        bool AllocateProjectAllocation(TrprojectAllocation trProjectAllocation);
        bool DeleteProjectAllocation(int AllocationId);
        bool UpdateProjectAllocation(TrprojectAllocation trprojectAllocation);
    }
}
