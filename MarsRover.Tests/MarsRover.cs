
namespace MarsRover.Tests;

public class MarsRover
{

    private int[] Position { get; set; } = new int[2];
    private enum Orientations { NORTH, EAST }
    private Orientations Orientation { get; set; } = Orientations.NORTH;

    public MarsRover()
    {
        Position[0] = 0;
        Position[1] = 0;
    }

    public string Input(string input)
    {
        foreach (var c in input)
        {
            if (c.ToString().ToUpperInvariant() == "R")
            {
                Orientation = Orientations.EAST;
            }
            if (c.ToString().ToUpperInvariant() == "M")
            {
                var V = Orientation == Orientations.NORTH ? 1 : 0;
                Position[V]++;
                if (Position[V] == 10)
                {
                    Position[V] = 0;
                }
            }
        }
        var OrientationCharacter = Orientation == Orientations.NORTH ? 'N' : 'E';
        return $"{Position[0]}:{Position[1]}:{OrientationCharacter}";
    }
}
