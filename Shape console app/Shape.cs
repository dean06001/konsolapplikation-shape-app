using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace konsolapplikation_app
{
    internal class Shape
    {
        protected double width;
        protected double height;

        public Shape (double w, double h)
        {
            width = w;
            height = h;
        }
    }

    internal class Triangle : Shape
    {
        protected double width;
        protected double height;

        public Triangle(double w, double h) : base (w, h)
        {
            width = w;
            height = h;
        }

        public double Area (double width, double height)
        {
            return (width * height)/2;
        }

        public double Circumference (double width, double height)
        {
            double hypotenuse = Math.Sqrt(width * width + height * height);
            double sum = hypotenuse + width + height;
            return sum;
        }
    }

    internal class Rectangle : Shape
    {
        protected double width;
        protected double height;

        public Rectangle (double w, double h) : base(w, h)
        {
            width = w;
            height = h;
        }

        public double Area (double width, double height)
        {
            return width * height;
        }

        public double Circumference(double width, double height)
        {
            double sum = (width * 2) + (height * 2);
            return sum;
        }
    }
}
