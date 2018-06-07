using System;
using System.Linq;
using Xunit;
namespace Collections.Test
{
    public class ConsultantsTest
    {
        private Consultants _consultants;

        public ConsultantsTest()
        {
            _consultants = new Consultants();
        }

        [Fact]
        public void SouldBeLength11()
        {
            var expectedNumberConsultants = 11;         
            Assert.Equal(expectedNumberConsultants, _consultants.People.Count);
        }

        [Fact]
        public void SouldBe5ConsultantsWhenIRequestSquad1()
        {
            var expectedNumberConsultants = 5;
            Assert.Equal(expectedNumberConsultants, _consultants.GetNumberConsultantsBySquad(1));
        }

        [Fact]
        public void SouldBe6ConsultantsWhenIRequestSquad2()
        {
            var expectedNumberConsultants = 5;
            Assert.Equal(expectedNumberConsultants,_consultants.GetNumberConsultantsBySquad(2));
        }

        [Fact]
        public void SouldBe2ConsultantsWhenIRequestForTradeMaster()
        {
            var expectedNumberConsultants = 2;
            Assert.Equal(expectedNumberConsultants,_consultants.GetNumberConsultantsByProject("TradeMaster"));
        }

        [Fact]
        public void SouldReturnTwoNamesConsultantsWhenIRequestForTradeMaster()
        {
            var consultantsInTradeMaster = _consultants.GetConsultantsByProject("TradeMaster");
            
            Assert.Equal("Albero",consultantsInTradeMaster[0]);
            Assert.Equal("Eduardo",consultantsInTradeMaster[1]);
        }

        [Fact]
        public void SouldReturn_Or_lan_di_to_WhenIRequestForBA()
        {
            var numberOfBa = _consultants.GetNumberConsultantsByRol("BA");
            const int expectedNumberOfConsultants = 1;

            Assert.Equal(expectedNumberOfConsultants, numberOfBa);
           
        }

        [Fact]
        public void ShouldReturn2DevswhenIRequestForIBUI(){
            var expectedNumberConsultants = 2;
            const string project = "IB.Project.UI";

            var currentConsultants = _consultants.filter
                                                .ByProject(project)
                                                .Get();
            
            Assert.Equal(expectedNumberConsultants,currentConsultants.ToList().Count);

        }

        [Fact]
        public void ShouldReturn1DevswhenIRequestForSentryAndDevRol(){
            var expectedNumberConsultants = 1;
            const string project = "Sentry";
            const string rol = "DEV";

            var currentConsultants = _consultants.filter
                                                .ByProject(project)
                                                .ByRol(rol)
                                                .Get();
            
            Assert.Equal(expectedNumberConsultants,currentConsultants.ToList().Count);

        }

        [Fact]
        public void ShouldReturn1DevswhenIRequestForSentryAndSquad1(){
            var expectedNumberConsultants = 1;
            const string project = "Sentry";
            
            var currentConsultants = _consultants.filter
                                                .ByProject(project)
                                                .BySquad(1)
                                                .Get();
            
            Assert.Equal(expectedNumberConsultants,currentConsultants.ToList().Count);

        }
        
    }
}