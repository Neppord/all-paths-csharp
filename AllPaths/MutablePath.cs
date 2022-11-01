namespace AllPaths;

public class MutablePath: List<Room>
{
    public MutablePath(MutablePath path): base(path)
    {
    }

    public MutablePath(): base()
    {
    }

    public override string ToString()
    {
        string ret = "[]";
        foreach (var room in this)
        {
            ret += ", " + room.ToString();
        }
        return ret;
    }
}