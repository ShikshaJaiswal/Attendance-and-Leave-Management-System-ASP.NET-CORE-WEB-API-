using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;

namespace ALMS.API.Repositories
{
    interface IProjectRepository
    {
        List<MsprojectDetail> GetProject();
        MsprojectDetail GetProject(int ProjectId);
        bool AddProject(MsprojectDetail msProjectDetail);
        bool DeleteProject(int ProjectId);
        bool UpdateProject(MsprojectDetail msProjectDetail);
    }
}
