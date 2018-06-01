using System;
using Xunit;

namespace Collections.Test
{
    public class CitizensTest
    {
        [Fact]
        public void ShouldBeRoeroWhenRequestIdNumber()
        {
            Assert.Equal("Robero",new Citizens().GetCitizenById("1617898743"));
        }
    }
}