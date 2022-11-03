using MindBoxTestProject;

namespace AreaCalculationLibraryTest
{
    public class AreaCalculationTest
    {
        [Theory]
        [InlineData(3, 4, 5, 6.0, 3)]
        [InlineData(1, 1, 6, 6.0, 3)]
        [InlineData(3, -4, 5, 6.0, 3)]
        public void CanCalculateTriangleTheory(
            double firstSide,
            double secondSide,
            double thirdSide,
            double expected,
            int precision
        )
        {
            Assert.Equal(
                expected,
                AreaCalculationLibrary.CalculateArea(firstSide, secondSide, thirdSide),
                precision
            );
        }

        [Theory]
        [InlineData(5, 78.539816, 6)]
        [InlineData(-5, 0, 3)]
        public void CanCalculateTheory(double radius, double expected, int precision)
        {
            Assert.Equal(expected, AreaCalculationLibrary.CalculateArea(radius), precision);
        }
    }
}
