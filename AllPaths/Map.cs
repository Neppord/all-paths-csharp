namespace AllPaths;

public class Map : HashSet<Room>
{
    public static readonly Map LongCorridor = Parse(new()
    {
        "S                                    ",
        "#################################### ",
        "                                     ",
        " ####################################",
        "                                     ",
        "#################################### ",
        "                                     ",
        " ####################################",
        "                                     ",
        "#################################### ",
        "G                                    ",

    });
    public static readonly Map SplitEnd = Parse(new()
    {
        "S             ",
        "############# ",
        "              ",
        " #############",
        "              ",
        "############# ",
        "              ",
        " #############",
        "              ",
        "# # # # # # # ",
        "              ",
        " # # # # # # #",
        "G             ",

    });
    public static readonly Map  HardMap = Parse(new()
    {
        " #    ##    ####      #         #       # ",
        " #  # ##### #  # ## # ## # ## # # ## ## #G",
        "S#  # ##  # #  # #  # #  # #  # #  # #  # ",
        " #### ## ## # ## # ## #### # ## #### # ## ",
        "      ## #  #    ####   ## #### #         ",
        " #######  # ## #      #         #       ##",
        " ## #  ## # ## # ## # ## # ## # # ## ## # ",
        " #  #  #  # #  # #  # #  # #  # #  # #  # ",
        " # ##  # ## # ## # ## # ## #### #### # ## ",
        "                 #    #    #              "
            
    });

    public static Map Parse(List<string> stringMap)
    {
        var map = new Map();
        for (var x = 0; x < stringMap.Count; x++)
        {
            for (var y = 0; y < stringMap[x].Length; y++)
            {
                Room room = new Room(x, y);
                switch (stringMap[x][y])
                {
                    case ' ':
                        map.Add(room);
                        break;
                    case 'S':
                        map.Start = room;
                        map.Add(room);
                        break;
                    case 'G':
                        map.Goal = room;
                        map.Add(room);
                        break;
                }
            }
        }

        return map;
    }
    public Room Goal { get; set; }
    public Room Start { get; set; }
}