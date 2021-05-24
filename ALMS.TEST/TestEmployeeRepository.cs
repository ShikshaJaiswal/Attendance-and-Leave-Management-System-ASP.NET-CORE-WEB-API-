using System;
using Xunit;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.TEST
{
    public class TestEmployeeRepository
    {
        private EmployeeRepository repository = null;
        public TestEmployeeRepository()
        {
            repository = new EmployeeRepository();
        }
        [Fact]
        public void TestGetEmployees()
        {
            //arrange
            int expected = 16;
            //action
            int actual = repository.GetEmployee().Count;
            //assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestGetEmployee()
        {
            //arrange
            int EmployeeId = 10001;
            //action
            MsemployeeDetail obj = repository.GetEmployee(EmployeeId);
            //assert
            Assert.NotNull(obj);

        }
        [Fact]
        public void TestAddEmployee()
        {
            //arrange
            MsemployeeDetail p = new MsemployeeDetail { EmployeeName = "Paras", EmployeeDob =Convert.ToDateTime("02/02/1990"), EmployeeAge=26, EmployeePhoneNumber=9873456890, EmployeeEmailId= "amit@yahoo.com", EmployeeAddress="Hyderabad", EmployeeDesignation="associate engineer", ManagerId=10002, Status="pending", CreatedBy=10001, CreatedDate=Convert.ToDateTime("2021 - 04 - 03 20:17:39.927") };
            //action
            bool result = repository.AddEmployee(p);
            //assert
            Assert.True(result);

        }
        //[Fact]
        //public void DeleteProduct()
        //{
        //    //arrange
        //    int Pid = 100;

        //    //action
        //    bool result = repository.DeleteProduct(Pid);
        //    //assert
        //    Assert.True(result);

        //}
        //[Fact]
        //public void TestUpdateProduct()
        //{
        //    //arrange
        //    Product p = new Product() { Pid = 100, Pname = "GGG", Price = 100, Stock = 100 };
        //    //action
        //    bool result = repository.UpdateProduct(p);
        //    //assert
        //    Assert.True(result);

        //}
    }
}
