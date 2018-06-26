using Domain;
using Xunit;

namespace CollectionInterfaces.Test
{
    public class ProjectEnumerableTest
    {
        [Fact]
        public void SouldReturn2ProjectsNotNulls()
        {
            var projectEnumerable = new ProjectEnumerable(new Project(), null, new Project());

            var currentNumberProjects = projectEnumerable.GetTotalOfProjects();

            var expectedNumberProjects = 2;
            Assert.Equal(expectedNumberProjects, currentNumberProjects);
        }
    }
}