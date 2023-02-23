using TestTaskMindBox.Models;
using Xunit;
namespace TestTaskMindBox.Tests;

public class CalculateAreaTests
{
    [Fact]
    public void CalculateAreaTriangle_Success()
    {
        var trueTriangle = new Triangle(6, 8, 10);
        var area = trueTriangle.CalculateArea();
        
        Assert.Equal(24,area);
    }
    
    [Fact]
    public void CalculateAreaTriangleTests_
}