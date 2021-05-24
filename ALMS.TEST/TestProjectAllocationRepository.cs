using System;
using Xunit;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.TEST
{
    public class TestProjectAllocationRepository
    {
        private ProjectAllocationRepository repository = null;
        public TestProjectAllocationRepository()
        {
            repository = new ProjectAllocationRepository();
        }
        [Fact]
        public void TestGetProjectAllocationDetails()
        {
            //arrange
            int expected = 9;
            //action
            int actual = repository.GetProjectAllocationDetails().Count;
            //assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestGetProjectAllocationDetail()
        {
            //arrange
            int AllocationId = 1;
            //action
            TrprojectAllocation obj = repository.GetProjectAllocationDetails(AllocationId);
            //assert
            Assert.NotNull(obj);

        }
        [Fact]
        public void TestAllocateProjectAllocation()
        {
            //arrange
            TrprojectAllocation p = new TrprojectAllocation { ProjectId=2, EmployeeId=10003, Status="active", CreatedBy=10001, CreatedDate= Convert.ToDateTime("2021-04-14") };
            //action
            bool result = repository.AllocateProjectAllocation(p);
            //assert
            Assert.True(result);

        }
    }
}
