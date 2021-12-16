using System;
using Xunit;

namespace TsekhTest
{
    public class UnitTest1
    {
        [Fact]
        public void TsekhMoneyTest()
        {
            int x = 5600;
            int y = 8900;

            int result = x + y;

            Assert.True(result > 0);
        }
    }
}
