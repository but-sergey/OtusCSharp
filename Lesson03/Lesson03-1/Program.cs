using System.Collections.Generic;

namespace Lesson03_1
{
    public struct Point
    {
        public double X, Y;
    }

    public interface IFigure
    {
        List<Point> Points { get; }
        double GetPerimeter();
    }

    public abstract class Figure : IFigure { }

    public class Round : Figure { }

    public class Triangle : Figure { }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
