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
        _a = a > 0 ? a : throw new ArgumentException("side cannot be less than zero");
        _b = b > 0 ? b : throw new ArgumentException("side cannot be less than zero");
        _c = c > 0 ? c : throw new ArgumentException("side cannot be less than zero");
        _p = (_a + _b + _c) / 2;
    }

    public double CalculateArea()
    {
        return Math.Sqrt(_p * (_p - _a) * (_p - _b) * (_p - _c));
    }
}