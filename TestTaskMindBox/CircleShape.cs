using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskMindBox
{
    public class CircleShape : IShape
    {
        public double Radius { get; set; }

        public CircleShape(double radius)
        {
            Radius = radius;
        }

        public double CalculateArea()
        {
            if (Radius <= 0)
                throw new ArgumentException("Radius must be more than zero ");
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
