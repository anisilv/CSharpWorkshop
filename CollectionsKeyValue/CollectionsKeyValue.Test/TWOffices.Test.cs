using System;
using CollectionsKeyValue;
using CollectionsKeyValue.Test;
using Xunit;

namespace CollectionKeyValue.Test
{
    public class TWOfficesTest
    {
        TWOffices _offices;

        public TWOfficesTest()
        {
            _offices = new TWOffices(new OfficeRepositoryTest());
        }

        [Fact]
        public void ShouldGetQuitoOfficeWhenISendUIO()
        {
            var expectedOffice = "Quito";
            var currentOffice = _offices.GetOffice("UIO");

            Assert.Equal(expectedOffice,currentOffice);
        }

        [Fact]
        public void ShouldThrowExceptionWhenISendFoo()
        {
            Assert.Throws<ArgumentException>(()=> _offices.GetOffice("foo"));
        }

        
    }
}
