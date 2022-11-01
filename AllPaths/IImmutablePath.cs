namespace ShortestPath;

public interface IImmutablePath
{
    public static IImmutablePath Empty() => new Empty();
    public IImmutablePath Add(Room room) => new ImmutablePath(this, room);
    bool Contains(Room room);
}

record Empty : IImmutablePath
{
    public bool Contains(Room room) => false;

    public override string ToString()
    {
        return "[]";
    }
}

record ImmutablePath(IImmutablePath History, Room Room) : IImmutablePath
{
    public bool Contains(Room room) => Equals(Room, room) || History.Contains(room);

    public override string ToString()
    {
        return $"{History},{Room}";
    }
}