using System;
using Xunit;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.TEST
{
    public class TestAttendanceRepository
    {
        private AttendanceRequestRepository repository = null;
        public TestAttendanceRepository()
        {
            repository = new AttendanceRequestRepository();
        }
        [Fact]
        public void TestGetAttendanceRequests()
        {
            //arrange
            int expected = 8;
            //action
            int actual = repository.GetTrAttendanceDetails().Count;
            //assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestGetTrAttendanceRequest()
        {
            //arrange
            int AttendanceId = 1;
            //action
            TrattendanceDetail obj = repository.GetTrAttendanceDetail(AttendanceId);
            //assert
            Assert.NotNull(obj);

        }
        [Fact]
        public void TestAddTrAttendanceDetail()
        {
            //arrange
           TrattendanceDetail p = new TrattendanceDetail {ProjectId=2, EmployeeId=10007, AttedanceDate= Convert.ToDateTime("2021-04-13 13:49:00.000"), AttendanceStatus="pending" };
            //action
            bool result = repository.AddTrAttendanceDetail(p);
            //assert
            Assert.True(result);

        }
    }
}
