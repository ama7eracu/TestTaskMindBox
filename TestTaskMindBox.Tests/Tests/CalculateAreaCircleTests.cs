using TestTaskMindBox.Models;
using TestTaskMindBox.Tests.Common;
using Xunit;

namespace TestTaskMindBox.Tests.Tests;

public class CalculateAreaCircleTests
{
    [Fact]
    public void CalculateAreaCircle_Success()
    {
        var area = Seed.TrueCircle.CalculateArea();
        
        Assert.Equal(Seed.TrueCircleArea,area);
    }

    [Fact]
    public void CalculateAreaCircle_FailOnWrongArgument()
    {
        Assert.Throws<ArgumentException>(() => new Circle(-10));
    }
    
}