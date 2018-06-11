using Domain;
using Xunit;

namespace CollectionInterfaces.Test
{
    public class ProjectsTest
    {
        Projects _projects;

        [Fact]
        public void SouldReturn3Projects()
        {
           var sentry = new Project{Name = "Sentry", Code = "prj-001"};
            var tradeMaster = new Project{Name = "tradeMaster", Code = "prj-002"};
            var elm = new Project{Name = "ELM", Code = "prj-003"};

             _projects= new Projects(sentry,tradeMaster,elm);
             
            var expectedNumberProjects = 3;

            var currentNumberProjects = _projects.Count();
            
             //Assert.Equal(expectedNumberProjects, currentNumberProjects);
        }
    }
}