
namespace MarsRover.Tests;

public class MarsRoverTest
{
    [Fact]
    public void GivenEmptyInput_RoverReturnsStartingPosition()
    {
        var input = "";
        var expected = "0:0:N";

        var rover = new MarsRover();
        var actual = rover.Input(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given1MoveCommand_RoverMoves1North()
    {
        var input = "M";
        var expected = "0:1:N";

        var rover = new MarsRover();
        var actual = rover.Input(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given9MoveCommands_RoverMoves9North()
    {
        var input = "MMMMMMMMM";
        var expected = "0:9:N";

        var rover = new MarsRover();
        var actual = rover.Input(input);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Given10MoveCommands_RoverMovesToStartingPosition()
    {
        var input = "MMMMMMMMMM";
        var expected = "0:0:N";

        var rover = new MarsRover();
        var actual = rover.Input(input);

        Assert.Equal(expected, actual);
    }
}
