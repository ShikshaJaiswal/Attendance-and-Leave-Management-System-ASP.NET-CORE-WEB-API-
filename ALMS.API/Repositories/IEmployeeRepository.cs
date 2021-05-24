using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;

namespace ALMS.API.Repositories
{
    interface IEmployeeRepository
    {
        List<MsemployeeDetail> GetEmployee();
        MsemployeeDetail GetEmployee(long EmployeeId);
        bool AddEmployee(MsemployeeDetail msEmployeeDetail);
        bool DeleteEmployee(long EmployeeId);
        bool UpdateEmployee(MsemployeeDetail msEmployeeDetail);
    }
}
