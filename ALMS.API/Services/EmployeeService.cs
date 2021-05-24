using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.API.Services
{
    public class EmployeeService : IEmployeeService
    {
        private EmployeeRepository repository;

        public EmployeeService()
        {
            this.repository = new EmployeeRepository();
        }
        public bool AddEmployee(MsemployeeDetail msEmployeeDetail)
        {
            return repository.AddEmployee(msEmployeeDetail);
        }

        public bool DeleteEmployee(long EmployeeId)
        {
            return repository.DeleteEmployee(EmployeeId);
        }

        public List<MsemployeeDetail> GetEmployee()
        {
            return repository.GetEmployee();
        }

        public MsemployeeDetail GetEmployee(long EmployeeId)
        {
            return repository.GetEmployee(EmployeeId);
        }

        public bool UpdateEmployee(MsemployeeDetail msEmployeeDetail)
        {
            return repository.UpdateEmployee(msEmployeeDetail);
        }
    }
}
