using TestTaskMindBox.Models;

namespace TestTaskMindBox.Tests.Common;

public static class Seed
{
    public static readonly Triangle TrueTriangle = new Triangle(6, 8, 10);
    public static readonly Circle TrueCircle = new Circle(15);
    public static readonly double TrueTriangleArea=24;
    public static readonly double TrueCircleArea=Math.Pow(15,2)*Math.PI;
}