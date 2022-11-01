namespace AllPaths;

public static class Immutable
{
    public static IEnumerable<IImmutablePath> Solve(Map maze, Room start, Room goal)
    {
        return Solve(maze, goal, IImmutablePath.Empty(), start);
    }

    private static IEnumerable<IImmutablePath> Solve(Map maze, Room goal, IImmutablePath path, Room room)
    {
        if (path.Contains(room))
        {
            return new List<IImmutablePath>();
        }
        var nextPath = path.Add(room);
        if (Equals(room, goal))
        {
            return new List<IImmutablePath> { nextPath };
        }
        else
        {
            return room.Neighbours()
                .Where(maze.Contains)
                .SelectMany(nextRoom => Solve(maze, goal, nextPath, nextRoom));
        }
    }

}