using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;

namespace ALMS.API.Services
{
    interface ILeaveRequestService
    {
        List<TrleaveRequestDetail> GetTrLeaveRequestDetails();
        TrleaveRequestDetail GetTrLeaveRequestDetail(int LeaveRequestId);
        bool AddTrLeaveRequestDetail(TrleaveRequestDetail trLeaveRequestDetail);
        bool DeleteTrLeaveRequestDetail(int LeaveRequestId);
        bool UpdateTrLeaveRequestDetail(TrleaveRequestDetail trLeaveRequestDetail);
    }
}
