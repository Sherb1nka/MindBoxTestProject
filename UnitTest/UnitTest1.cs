using MindBoxTestProject;

namespace UnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void AreaTestTriangle()
        {
            Assert.Equal(6.0, AreaCalculationLibrary.CalculateArea(3, 4, 5), 3);
        }

        [Fact]
        public void AreaTestCircle()
        {
            Assert.Equal(78.539816, AreaCalculationLibrary.CalculateArea(5), 6);
        }

        [Fact]
        public void FailedTestTriangle1()
        {
            Assert.Equal(6.0, AreaCalculationLibrary.CalculateArea(1, 1, 6), 3);
        }

        [Fact]
        public void FailedTestTriangle2()
        {
            Assert.Equal(6.0, AreaCalculationLibrary.CalculateArea(3, -4, 5), 3);
        }

        [Fact]
        public void FailedTestCircle()
        {
            Assert.Equal(6.0, AreaCalculationLibrary.CalculateArea(-5), 3);
        }
    }
}
