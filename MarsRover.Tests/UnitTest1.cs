
namespace MarsRover.Tests;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var input = "";
        var expected = "0:0:N";

        var rover = new MarsRover();
        var actual = rover.input(input);

        Assert.Equal(expected, actual);
    }
}

public class MarsRover
{
    public string input(string input)
    {
        return "0:0:N";
    }
}
