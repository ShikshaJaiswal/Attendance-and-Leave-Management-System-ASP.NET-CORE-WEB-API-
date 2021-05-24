using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;

namespace ALMS.API.Repositories
{
    public class ProjectRepository : IProjectRepository
    {
        private Sprint2ALMSContext context;

        public ProjectRepository()
        {
            this.context = new Sprint2ALMSContext();
        }
        public bool AddProject(MsprojectDetail msProjectDetail)
        {
            context.MsprojectDetails.Add(msProjectDetail);
            context.SaveChanges();
            return true;
        }

        public bool DeleteProject(int ProjectId)
        {
            MsprojectDetail msProjectDetail = context.MsprojectDetails.Find(ProjectId);
            context.MsprojectDetails.Remove(msProjectDetail);
            context.SaveChanges();
            return true;
        }

        public List<MsprojectDetail> GetProject()
        {
            return context.MsprojectDetails.ToList();
        }

        public MsprojectDetail GetProject(int ProjectId)
        {
            return context.MsprojectDetails.Find(ProjectId);
        }

        public bool UpdateProject(MsprojectDetail msProjectDetail)
        {
            context.MsprojectDetails.Update(msProjectDetail);
            context.SaveChanges();
            return true;
        }
    }
}
