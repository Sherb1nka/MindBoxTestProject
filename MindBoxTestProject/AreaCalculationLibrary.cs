using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestProject
{
    public static class AreaCalculationLibrary
    {
        public static double CalculateArea(double radius)
        {
            try
            {
                var circle = new Circle(radius);
                return circle.CalculateArea();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Negative radius");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public static double CalculateArea(double firstSide, double secondSide, double thirdSide)
        {
            try
            {
                var triangle = new Triangle(firstSide, secondSide, thirdSide);
                return triangle.CalculateArea();
            }
            catch (ArgumentException)
            {
                throw new ArgumentException("Triangle sides can't be negative");
            }
            catch (InvalidTriangleException)
            {
                throw new ArgumentException("Triangle can't exist with such sides");
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
