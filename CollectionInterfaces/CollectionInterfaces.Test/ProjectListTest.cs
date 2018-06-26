using Domain;
using Xunit;

namespace CollectionInterfaces.Test
{
    public class SquadProjectsTest
    {
        private SquadProjects _projects;

        [Fact]
        public void souldReturnFacsetSecuritiesWhenAddProject(){

            _projects = new SquadProjects();

            var newProject = new ProjectTest.Builder()
                                            .WithName("Facset")
                                            .WithCode("ggn-001")
                                            .Build();

            var expectedProject = new ProjectTest.Builder()
                                            .WithName("Facset")
                                            .WithCode("ggn-001")
                                            .Build();
            _projects.Add(newProject);

            Project firsElement ;

            using(var e = _projects.GetEnumerator())
            {
                e.MoveNext();
                firsElement= e.Current;
            }

            Assert.True(firsElement.Name.Equals(expectedProject.Name));
        }
        
        [Fact]
        public void ShouldReturn2ElementsInList()
        {
            _projects = new SquadProjects();

            var expectedProjectNumber = 2;

            var newProject = new ProjectTest.Builder()
                                            .WithName("Facset")
                                            .WithCode("ggn-001")
                                            .Build();
            
            var newProject2 = new ProjectTest.Builder()
                                            .WithName("Sentry")
                                            .WithCode("ggn-002")
                                            .Build();
            
            _projects.Add(newProject);
            _projects.Add(newProject2);

            var currentProjectNumber = _projects.Count;

            Assert.Equal(expectedProjectNumber,currentProjectNumber);
        }


        
    }
}