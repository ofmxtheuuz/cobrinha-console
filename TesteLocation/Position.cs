namespace TesteLocation;

public class Position
{
    public int X { get; set; }
    public int Y { get; set; }

    public override string ToString()
    {
        return "{ X: " + this.X + ", Y: " + this.Y + " }";
    }
}