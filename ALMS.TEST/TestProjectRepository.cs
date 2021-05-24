using System;
using Xunit;
using ALMS.API.Models;
using ALMS.API.Repositories;

namespace ALMS.TEST
{
    public class TestProjectRepository
    {
        private ProjectRepository repository = null;
        public TestProjectRepository()
        {
            repository = new ProjectRepository();
        }
        [Fact]
        public void TestGetProjects()
        {
            //arrange
            int expected = 8;
            //action
            int actual = repository.GetProject().Count;
            //assert
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void TestGetProject()
        {
            //arrange
            int ProjectId = 1;
            //action
            MsprojectDetail obj = repository.GetProject(ProjectId);
            //assert
            Assert.NotNull(obj);

        }
        [Fact]
        public void TestAddProject()
        {
            //arrange
            MsprojectDetail p = new MsprojectDetail { ProjectName="Service8", ProjectTechnology="Vue", ProjectStartDate= Convert.ToDateTime("2021-04-12"), ProjectEndDate= Convert.ToDateTime("2021-05-12"), Status= "active", CreatedBy= 10001, CreatedDate= Convert.ToDateTime("2021-04-12") };
            //action
            bool result = repository.AddProject(p);
            //assert
            Assert.True(result);

        }
    }
}
