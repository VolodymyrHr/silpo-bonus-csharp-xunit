using System;
using Xunit;

namespace SilpoBonusCore.Tests
{
    public class DumbServiceTest
    {
        [Fact]
        public void Sum_of_twos_returns_four()
        {
            // Act
            int sum = DumbService.Sum(1, 1);

            // Assert
            Assert.Equal(2, sum);
        }

        [Theory]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -1, -2)]
        [InlineData(-1, 1, 0)]
        public void Sum_works_with_different_args(int a, int b, int expected)
        {
            // Act
            int sum = DumbService.Sum(a, b);

            // Assert
            Assert.Equal(expected, sum);
        }
    }
}
