using TestTaskMindBox.Interfaces;

namespace TestTaskMindBox.Models;

public class Circle : ICalculateArea
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius > 0 ? radius : throw new ArgumentException("radius cannot be less than zero");
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}