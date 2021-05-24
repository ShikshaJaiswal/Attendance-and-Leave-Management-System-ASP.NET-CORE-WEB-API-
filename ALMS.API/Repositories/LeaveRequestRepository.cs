using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;

namespace ALMS.API.Repositories
{
    public class LeaveRequestRepository
    {
        private Sprint2ALMSContext context;
        public LeaveRequestRepository()
        {
            this.context = new Sprint2ALMSContext();
        }
        public bool AddTrLeaveRequestDetail(TrleaveRequestDetail trLeaveRequestDetail)
        {
            context.TrleaveRequestDetails.Add(trLeaveRequestDetail);
            context.SaveChanges();
            return true;
        }

        public bool DeleteTrLeaveRequestDetail(int LeaveRequestId)
        {
            TrleaveRequestDetail trLeaveRequestDetail = context.TrleaveRequestDetails.Find(LeaveRequestId);
            context.TrleaveRequestDetails.Remove(trLeaveRequestDetail);
            context.SaveChanges();
            return true;
        }

        public TrleaveRequestDetail GetTrLeaveRequestDetail(int LeaveRequestId)
        {
            return context.TrleaveRequestDetails.Find(LeaveRequestId);
        }

        public List<TrleaveRequestDetail> GetTrLeaveRequestDetails()
        {
            return context.TrleaveRequestDetails.ToList();
        }

        public bool UpdateTrLeaveRequestDetail(TrleaveRequestDetail trLeaveRequestDetail)
        {
            context.TrleaveRequestDetails.Update(trLeaveRequestDetail);
            context.SaveChanges();
            return true;

        }
    }
}
