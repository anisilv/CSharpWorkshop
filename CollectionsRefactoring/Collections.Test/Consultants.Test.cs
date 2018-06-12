using System;
using Xunit;
namespace Collections.Test
{
    public class ConsultantsTest
    {
        private Consultants _consultants;

        public ConsultantsTest()
        {
            _consultants = new Consultants(new ConsultantsRepositoryTest());
        }

        [Fact]
        public void SouldBeLength11()
        {         
            Assert.Equal(11,_consultants.People.GetLength(0));
        }

        [Fact]
        public void SouldBe5ConsultantsWhenIRequestSquad1()
        {
            Assert.Equal(5,_consultants.GetNumberConsultantsBySquad(1));
        }

        [Fact]
        public void SouldBe6ConsultantsWhenIRequestSquad2()
        {
            Assert.Equal(5,_consultants.GetNumberConsultantsBySquad(2));
        }

        [Fact]
        public void SouldBe2ConsultantsWhenIRequestForTradeMaster()
        {
            Assert.Equal(2,_consultants.GetNumberConsultantsByProject("TradeMaster"));
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
            
            Assert.Equal(1,numberOfBa);
           
        }
        
    }
}