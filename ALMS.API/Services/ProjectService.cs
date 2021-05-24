using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.API.Services
{
    public class ProjectService
    {
        private ProjectRepository repository;

        public ProjectService()
        {
            this.repository = new ProjectRepository();
        }
        public bool AddProject(MsprojectDetail msProjectDetail)
        {
            return repository.AddProject(msProjectDetail);
        }

        public bool DeleteProject(int ProjectId)
        {
            return repository.DeleteProject(ProjectId);
        }

        public List<MsprojectDetail> GetProject()
        {
            return repository.GetProject();
        }

        public MsprojectDetail GetProject(int ProjectId)
        {
            return repository.GetProject(ProjectId);
        }

        public bool UpdateProject(MsprojectDetail msProjectDetail)
        {
            return repository.UpdateProject(msProjectDetail);
        }
    }
}
