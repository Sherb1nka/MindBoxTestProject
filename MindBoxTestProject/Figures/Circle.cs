using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBoxTestProject
{
    public class Circle : IAreaCalculatable
    {
        public double Radius { get; private set; }

        /// <summary>
        /// Circle constructor
        /// </summary>
        /// <param name="radius"></param>
        /// <exception cref="ArgumentException">Exception is thrown when radius is negative</exception>
        public Circle(double radius)
        {
            if (radius > 0)
                Radius = radius;
            else
                throw new ArgumentException();
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
