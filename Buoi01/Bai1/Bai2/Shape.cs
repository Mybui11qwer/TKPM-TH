using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    abstract class Shape
    {
        public abstract double CalculatePerimeter();
        public abstract double CalculateArea();

        public class Circle : Shape
        {
            private double radius;

            public double Radius
            {
                get { return radius; }
                set { radius = value; }
            }

            public Circle( double radius)
            {
                this.radius = radius;
            }

            public override double CalculatePerimeter()
            {
                return 2 * Math.PI*radius;
            }

            public override double CalculateArea()
            {
                return Math.PI * Math.Pow(radius, 2);
            }
        }

        public class Rectangle : Shape
        {
            private double width;
            private double lenght;

            public double Width
            {
                get { return width; }
                set { width = value; }
            }
            public double Lenght
            {
                get { return lenght; }
                set { lenght = value; }
            }

            public Rectangle(double width, double lenght)
            {
                this.width = width;
                this.lenght = lenght;
            }

            public override double CalculatePerimeter()
            {
                return (width + lenght) * 2;
            }

            public override double CalculateArea()
            {
                return width * lenght;
            }
        }
    }
}
