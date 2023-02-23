using System.Net.NetworkInformation;
using TestTaskMindBox.Interfaces;

namespace TestTaskMindBox.Models;

public class Circle : ICalculateArea
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(_radius, 2);
    }
}