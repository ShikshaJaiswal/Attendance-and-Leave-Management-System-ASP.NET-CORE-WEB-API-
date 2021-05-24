using System;
using Xunit;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.TEST
{
    public class TestLeaveRequestRepository
    {
        private LeaveRequestRepository repository = null;
        public TestLeaveRequestRepository()
        {
            repository = new LeaveRequestRepository();
        }
        [Fact]
        public void TestGetTrLeaveRequestDetail()
        {
            //arrange
            int expected = 2;
            //action
            int actual = repository.GetTrLeaveRequestDetails().Count;
            //assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestGetTrAttendanceRequest()
        {
            //arrange
            int LeaveRequestId = 11;
            //action
            TrleaveRequestDetail obj = repository.GetTrLeaveRequestDetail(LeaveRequestId);
            //assert
            Assert.NotNull(obj);

        }
        [Fact]
        public void AddTrLeaveRequestDetail()
        {
            //arrange
            TrleaveRequestDetail p = new TrleaveRequestDetail { EmployeeId=10007, LeavesRemaining=3, LeaveRequestFrom= Convert.ToDateTime("2021-04-25"), LeaveRequestTo= Convert.ToDateTime("2021-04-27"), LeaveDescription="Family emergency", LeaveStatus="pending", LeaveRequestCreatedDate= Convert.ToDateTime("2021-04-13" )};
            //action
            bool result = repository.AddTrLeaveRequestDetail(p);
            //assert
            Assert.True(result);

        }
    }
}
