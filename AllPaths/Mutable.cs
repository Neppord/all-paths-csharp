namespace ShortestPath;

public static class Mutable
{
    public static List<MutablePath> Solve(Map maze, Room start, Room goal)
    {
        MutablePath path = new MutablePath();
        return Solve(maze, goal, path, start);
    }

    private static List<MutablePath> Solve(Map maze, Room goal, MutablePath path, Room room)
    {
        if (path.Contains(room))
        {
            return new List<MutablePath>();
        }
        MutablePath nextPath = new(path) { room };
        if (Equals(room, goal))
        {
            return new List<MutablePath> { nextPath };
        }
        else
        {
            return room.Neighbours()
                .Where(maze.Contains)
                .SelectMany(nextRoom => Solve(maze, goal, nextPath, nextRoom))
                .ToList();
        }
    }
}