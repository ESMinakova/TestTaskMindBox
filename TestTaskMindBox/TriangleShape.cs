using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTaskMindBox
{
    public class TriangleShape : IShape
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public TriangleShape(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double CalculateArea()
        {
            if (SideA <= 0 || SideB <= 0 || SideC <= 0)
                throw new ArgumentException("Each side must be more than zero");
            if (SideA + SideB < SideC || SideB + SideC < SideA || SideA + SideC < SideB)
                throw new ArgumentException("Еhe condition for the existence of a triangle is not met");
            double halfPerimeter = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(halfPerimeter * (halfPerimeter - SideA) * (halfPerimeter - SideB) * (halfPerimeter - SideC));
        }

        public bool IsRightAngle()
        {
            double[] sides = new double[] { SideA, SideB, SideC };
            Array.Sort(sides);
            return Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2) == Math.Pow(sides[2], 2);
        }
    }
}
