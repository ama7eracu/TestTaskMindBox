using TestTaskMindBox.Models;
using TestTaskMindBox.Tests.Common;
using Xunit;

namespace TestTaskMindBox.Tests.Tests;

public class CalculateAreaTriangleTests
{
    [Fact]
    public void CalculateAreaTriangle_Success()
    {
        
        var area = Seed.TrueTriangle.CalculateArea();
        
        Assert.Equal(Seed.TrueTriangleArea,area);
    }

    [Fact]
    public void CalculateAreaTriangle_FailOnWrongArgument()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(-5, 3, 4));
    }
}