using AllPaths;
using static AllPaths.Immutable;

var paths = Solve(Map.HardMap).ToList();
Console.WriteLine(paths.Count);