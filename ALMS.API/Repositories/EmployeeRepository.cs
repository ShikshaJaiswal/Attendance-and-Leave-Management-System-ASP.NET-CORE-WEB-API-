using ALMS.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ALMS.API.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private Sprint2ALMSContext context;

        public EmployeeRepository()
        {
            this.context = new Sprint2ALMSContext();
        }
        public bool AddEmployee(MsemployeeDetail msEmployeeDetail)
        {
            context.MsemployeeDetails.Add(msEmployeeDetail);
            context.SaveChanges();
            return true;
        }

        public bool DeleteEmployee(long EmployeeId)
        {
            MsemployeeDetail msEmployeeDetail = context.MsemployeeDetails.Find(EmployeeId);
            context.MsemployeeDetails.Remove(msEmployeeDetail);
            context.SaveChanges();
            return true;
        }

        public List<MsemployeeDetail> GetEmployee()
        {
            return context.MsemployeeDetails.ToList();
        }

        public MsemployeeDetail GetEmployee(long EmployeeId)
        {
            return context.MsemployeeDetails.Find(EmployeeId);
        }

        public bool UpdateEmployee(MsemployeeDetail msEmployeeDetail)
        {
            context.MsemployeeDetails.Update(msEmployeeDetail);
            context.SaveChanges();
            return true;
        }


       
    }
}
