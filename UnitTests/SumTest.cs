using UnitTestDemoGithubActions;

namespace UnitTests
{
    public class SumTest
    {
        [Fact]
        public void TestAdd()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(3, 5);
            Assert.Equal(8, result);
        }
    }
}