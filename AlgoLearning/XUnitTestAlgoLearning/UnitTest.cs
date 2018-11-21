using AlgoLearning.Recursive;
using Xunit;

namespace XUnitTestAlgoLearning
{
    public class UnitTest
    {
        [Theory]
        [InlineData(3, 6)]
        [InlineData(4, 24)]
        [InlineData(5, 120)]
        [InlineData(6, 720)]
        public void TestFactorial(int value, int expected)
        {
            int actual = Factorial.CalculateFactorial(value);
            Assert.Equal(expected, actual);
        }
    }
}
