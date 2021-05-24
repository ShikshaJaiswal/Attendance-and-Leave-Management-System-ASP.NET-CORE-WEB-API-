using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.API.Services
{
    public class AttendanceRequestService
    {
        private AttendanceRequestRepository repository = null;
        public AttendanceRequestService()
        {
            this.repository = new AttendanceRequestRepository();
        }
        public List<TrattendanceDetail> GetTrAttendanceDetails()
        {
            return repository.GetTrAttendanceDetails();
        }
        public TrattendanceDetail GetTrAttendanceDetail(int AttendanceId)
        {
            return repository.GetTrAttendanceDetail(AttendanceId);
        }
        public bool AddTrAttendanceDetail(TrattendanceDetail trAttendanceDetail)
        {
            return repository.AddTrAttendanceDetail(trAttendanceDetail);
        }
        public bool DeleteTrAttendanceDetail(int AttendanceId)
        {
            return repository.DeleteTrAttendanceDetail(AttendanceId);

        }
        public bool UpdateTrAttendanceDetail(TrattendanceDetail trAttendanceDetail)
        {
            return repository.UpdateTrAttendanceDetail(trAttendanceDetail);

        }
    }
}
