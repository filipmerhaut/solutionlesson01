namespace XUnitTests;
using MyMathLibrary;

public class UnitTest1
{
    [Fact]
    public void TestAddMethod2plus3() => Assert.Equal(5, Class1.Add(2, 3));

    [Fact]
    public void TestAddMethod100plus333() => Assert.Equal(1333, Class1.Add(1000, 333));

    [Fact]
    public void TestSubstractMethod2plus3() => Assert.Equal(-1, Class1.Subtract(2, 3));

    [Fact]
    public void TestSubstractMethod1000plus333() => Assert.Equal(667, Class1.Subtract(1000, 333));

    [Theory]
    [InlineData(1, 1, 2)]
    [InlineData(1, 2, 3)]
    [InlineData(2, 3, 5)]
    [InlineData(3, 5, 8)]
    [InlineData(5, 8, 13)]
    [InlineData(8, 13, 21)]
    [InlineData(13, 21, 34)]
    [InlineData(21, 34, 55)]
    public void TestAddMethod(int a, int b, int expected)
    {
        Assert.Equal(expected, Class1.Add(a, b));
    }

}