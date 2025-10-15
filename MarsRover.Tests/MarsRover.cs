
namespace MarsRover.Tests;

public class MarsRover
{
    private int[] Position { get; set; } = new int[2];
    public MarsRover()
    {
        Position[0] = 0;
        Position[1] = 0;
    }

    public string Input(string input)
    {
        foreach(var c in input)
        {
            if(c.ToString().ToUpperInvariant() == "M")
            {
                Position[1]++;
            }
        }
        return $"{Position[0]}:{Position[1]}:N";
    }
}
