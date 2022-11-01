namespace AllPaths;

public class Map : HashSet<Room>
{
    public static Map Parse(List<string> stringMap)
    {
        var map = new Map();
        for (var x = 0; x < stringMap.Count; x++)
        {
            for (var y = 0; y < stringMap[x].Length; y++)
            {
                if (stringMap[x][y] != '#')
                {
                    map.Add(new Room(x, y));
                }
            }
        }

        return map;
    }
}