using AllPaths;
using static AllPaths.Mutable;

var paths = Solve(Map.HardMap).ToList();
Console.WriteLine(paths.Count);