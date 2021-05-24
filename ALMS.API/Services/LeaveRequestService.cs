using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.API.Services
{
    public class LeaveRequestService
    {
        private LeaveRequestRepository repository = null;
        public LeaveRequestService()
        {
            this.repository = new LeaveRequestRepository();
        }
        public List<TrleaveRequestDetail> GetTrLeaveRequestDetails()
        {
            return repository.GetTrLeaveRequestDetails();
        }
        public TrleaveRequestDetail GetTrLeaveRequestDetail(int LeaveRequestId)
        {
            return repository.GetTrLeaveRequestDetail(LeaveRequestId);
        }
        public bool AddTrLeaveRequestDetail(TrleaveRequestDetail trLeaveRequestDetail)
        {
            return repository.AddTrLeaveRequestDetail(trLeaveRequestDetail);
        }
        public bool DeleteTrLeaveRequestDetail(int LeaveRequestId)
        {
            return repository.DeleteTrLeaveRequestDetail(LeaveRequestId);

        }
        public bool UpdateTrLeaveRequestDetail(TrleaveRequestDetail trLeaveRequestDetail)
        {
            return repository.UpdateTrLeaveRequestDetail(trLeaveRequestDetail);

        }
    }
}
