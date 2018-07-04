using Domain;
using Xunit;

namespace CollectionInterfaces.Test
{
    public class ProjectCollectionTest
    {
        ProjectCollection _projects;
        public ProjectCollectionTest()
        {
            _projects = new ProjectCollection();
        }

        [Fact]
        public void souldAddNewItemToCollection(){

            var newProject = new ProjectTest.Builder()
                                            .WithName("Facset")
                                            .WithCode("ggn-001")
                                            .Build();

            _projects.Add(newProject);

            var expectedProjectsNumber = 1;

            Assert.Equal(expectedProjectsNumber,_projects.Count);
        }

        [Fact]
        public void souldReturnFacsetSecuritiesWhenAddProject(){

            _projects = new ProjectCollection();

            var newProject = new ProjectTest.Builder()
                                            .WithName("Facset")
                                            .WithCode("ggn-001")
                                            .Build();

            var expectedProject = new ProjectTest.Builder()
                                            .WithName("Facset-Securities")
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
        
    }
}