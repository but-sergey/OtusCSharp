using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace Lesson03_1
{
    public struct Point
    {
        public double X, Y;
        public double Length(Point p) => Math.Sqrt(Math.Pow(this.X - p.X, 2) + Math.Pow(this.Y - p.Y, 2));
    }

    public interface IFigure
    {
        List<Point> Points { get; }
        double GetPerimetr();
    }

    internal abstract class Figure : IFigure
    {
        protected List<Point> _points;
        public List<Point> Points => _points;
        public abstract double GetPerimetr();
    }

    internal class Round : Figure
    {
        public double Radius { get; set; }
        public Point Centr => Points[0];
        public override double GetPerimetr() => Radius * 2 * Math.PI;
        public Round(double x, double y, double radius)
        {
            Radius = radius;
            Points.Add(new Point() { X = x, Y = y });
        }
    }

    internal class Triangle : Figure
    {
        public Point p1 => Points[0];
        public Point p2 => Points[1];
        public Point p3 => Points[2];
        public override double GetPerimetr() => p1.Length(p2) + p2.Length(p3) + p3.Length(p1);
        public Triangle(double x1, double y1, double x2, double y2, double x3, double y3)
            : this(new Point() { X = x1, Y = y1 },
                  new Point() { X = x2, Y = y2 },
                  new Point() { X = x3, Y = y3 })
        { }
        public Triangle(Point p1, Point p2, Point p3)
        {
            Points.Add(p1);
            Points.Add(p2);
            Points.Add(p3);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
