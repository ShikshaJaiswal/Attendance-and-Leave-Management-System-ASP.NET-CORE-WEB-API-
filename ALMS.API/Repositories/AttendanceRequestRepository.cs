using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;

namespace ALMS.API.Repositories
{
    public class AttendanceRequestRepository
    {
        private Sprint2ALMSContext context;
        public AttendanceRequestRepository()
        {
            this.context = new Sprint2ALMSContext();
        }
        public bool AddTrAttendanceDetail(TrattendanceDetail trAttendanceDetail)
        {
            context.TrattendanceDetails.Add(trAttendanceDetail);
            context.SaveChanges();
            return true;
        }

        public bool DeleteTrAttendanceDetail(int AttendanceId)
        {
            TrattendanceDetail trAttendanceDetail = context.TrattendanceDetails.Find(AttendanceId);
            context.TrattendanceDetails.Remove(trAttendanceDetail);
            context.SaveChanges();
            return true;

        }

        public TrattendanceDetail GetTrAttendanceDetail(int AttendanceId)
        {
            return context.TrattendanceDetails.Find(AttendanceId);
        }
        public bool UpdateTrAttendanceDetail(TrattendanceDetail trAttendanceDetail)
        {
            context.TrattendanceDetails.Update(trAttendanceDetail);
            context.SaveChanges();
            return true;

        }
        public List<TrattendanceDetail> GetTrAttendanceDetails()
        {
            return context.TrattendanceDetails.ToList();
        }
    }
}
