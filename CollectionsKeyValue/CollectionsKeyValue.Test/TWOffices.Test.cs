using System;
using CollectionsKeyValue;
using Xunit;

namespace CollectionKeyValue.Test
{
    public class TWOfficesTest
    {
        [Fact]
        public void ShouldGetQuitoOfficeWhenISendUIO()
        {
            var offices = new TWOffices();

            var expectedOffice = "Quito";

            var currentOffice = offices.GetOffice("UIO");

            Assert.Equal(expectedOffice,currentOffice);
        }

        [Fact]
        public void ShouldThrowExceptionWhenISendFoo()
        {
            var offices = new TWOffices();

            Assert.Throws<ArgumentException>(()=> offices.GetOffice("foo"));
        }
    }
}
