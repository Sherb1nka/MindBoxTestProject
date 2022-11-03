using System;

namespace MindBoxTestProject
{
    public class Triangle : IAreaCalculatable
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set; }
        public double ThirdSide { get; private set; }
        public TriangleType TriangleType { get; private set; }

        /// <summary>
        /// Triangle constructor
        /// </summary>
        /// <param name="firstSide"></param>
        /// <param name="secondSide"></param>
        /// <param name="thirdSide"></param>
        /// <exception cref="ArgumentException">Exception is thrown when one or many sides of triangle are negative</exception>
        /// <exception cref="InvalidTriangleException">Exception is thrown when provided sides cannot form a triangle</exception>
        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide < 0 || secondSide < 0 || thirdSide < 0)
            {
                throw new ArgumentException();
            }

            if (
                firstSide + secondSide <= thirdSide
                || firstSide + thirdSide <= secondSide
                || secondSide + thirdSide <= firstSide
            )
            {
                throw new InvalidTriangleException("Треугольник не существует");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            TriangleType = SetType();
        }

        public double CalculateArea()
        {
            switch (TriangleType)
            {
                case TriangleType.RightTriangleFirstSideHypotenuse:
                    return SecondSide * ThirdSide / 2;
                case TriangleType.RightTriangleSecondSideHypotenuse:
                    return FirstSide * ThirdSide / 2;
                case TriangleType.RightTriangleThirdSideHypotenuse:
                    return FirstSide * SecondSide / 2;
                case TriangleType.NotRightTriangle:
                    var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
                    return Math.Sqrt(
                        semiPerimeter
                            * (semiPerimeter - FirstSide)
                            * (semiPerimeter - SecondSide)
                            * (semiPerimeter - ThirdSide)
                    );
                default:
                    return 0;
            }
        }

        private TriangleType SetType()
        {
            var firstSideSquared = Math.Pow(FirstSide, 2);
            var secondSideSquared = Math.Pow(SecondSide, 2);
            var thirdSideSquared = Math.Pow(ThirdSide, 2);

            if (Math.Abs(firstSideSquared + secondSideSquared - thirdSideSquared) < 0.1)
                return TriangleType.RightTriangleThirdSideHypotenuse;
            if (Math.Abs(firstSideSquared + thirdSideSquared - secondSideSquared) < 0.1)
                return TriangleType.RightTriangleSecondSideHypotenuse;
            if (Math.Abs(secondSideSquared + thirdSideSquared - firstSideSquared) < 0.1)
                return TriangleType.RightTriangleFirstSideHypotenuse;

            return TriangleType.NotRightTriangle;
        }
    }
}
