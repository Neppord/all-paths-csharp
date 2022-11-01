namespace ShortestPath;

public class MutablePath: List<Room>
{
    public MutablePath(MutablePath path): base(path)
    {
    }

    public MutablePath(): base()
    {
    }
}