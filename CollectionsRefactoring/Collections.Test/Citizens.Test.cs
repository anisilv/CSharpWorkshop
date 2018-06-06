using System;
using Xunit;

namespace Collections.Test
{
    public class CitizensTest
    {
        [Fact]
        public void ShouldBeRoeroWhenRequestIdNumber()
        {
            Assert.Equal("Robero",new Citizens().GetById("1617898743"));
        }
    }
}