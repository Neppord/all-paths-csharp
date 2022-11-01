namespace AllPaths;

public class Room : Tuple<int, int>
{
    public Room(int item1, int item2) : base(item1, item2)
    {
    }
    private Room North() => new(Item1, Item2 - 1);
    private Room South() => new(Item1, Item2 + 1);
    private Room West() => new(Item1 - 1, Item2);
    private Room East() => new(Item1 + 1, Item2);
    public IEnumerable<Room> Neighbours() => new[] { West(), East(), North(), South() };
}