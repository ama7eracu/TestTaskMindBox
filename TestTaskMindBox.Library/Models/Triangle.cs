using TestTaskMindBox.Interfaces;

namespace TestTaskMindBox.Models;

public class Triangle : ICalculateArea
{
    private readonly double _a;
    private readonly double _b;
    private readonly double _c;
    private readonly double _p; // semi-perimeter

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
        _p = (_a + _b + _c) / 2;
    }

    public double CalculateArea()
    {
        return Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p * _c));
    }

    
}