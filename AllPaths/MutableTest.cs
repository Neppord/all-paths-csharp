namespace AllPaths;

public class MutableTest
{
    [Test]
    public void StartAtGoal()
    {
        var onlyRoom = new Room(0, 0);
        var maze = new Map { onlyRoom };
        
        var paths = Mutable.Solve(maze, onlyRoom, onlyRoom);
        
        Assert.That(paths, Has.One.EqualTo(new MutablePath{ onlyRoom }));
    }
    
    [Test]
    public void UnReachableGoal()
    {
        var start = new Room(0, 0);
        var goal = new Room(1, 1);
        var maze = new Map { start, goal };
        
        var paths = Mutable.Solve(maze, start, goal);
        
        Assert.That(paths, Is.Empty);
    }
    
    [Test]
    public void ShortEastCorridor()
    {
        var start = new Room(0, 0);
        var goal = new Room(1, 0);
        var maze = new Map { start, goal };
        
        var paths = Mutable.Solve(maze, start, goal);
        
        Assert.That(paths, Has.One.EqualTo(new MutablePath { start, goal }));
    }
    [Test]
    public void ShortWestCorridor()
    {
        var start = new Room(0, 0);
        var goal = new Room(-1, 0);
        var maze = new Map { start, goal };
        
        var paths = Mutable.Solve(maze, start, goal);
        
        Assert.That(paths, Has.One.EqualTo(new MutablePath { start, goal }));
    }
    
    [Test]
    public void ShortNorthCorridor()
    {
        var start = new Room(0, 0);
        var goal = new Room(0, -1);
        var maze = new Map { start, goal };
        
        var paths = Mutable.Solve(maze, start, goal);
        
        Assert.That(paths, Has.One.EqualTo(new MutablePath { start, goal }));
    }
    [Test]
    public void ShortSouthCorridor()
    {
        var start = new Room(0, 0);
        var goal = new Room(0, 1);
        var maze = new Map { start, goal };
        
        var paths = Mutable.Solve(maze, start, goal);
        
        Assert.That(paths, Has.One.EqualTo(new MutablePath { start, goal }));
    }
    
    [Test]
    public void LongSouthCorridor()
    {
        var start = new Room(0, 0);
        var middle = new Room(0, 1);
        var goal = new Room(0, 2);
        var maze = new Map { start, middle, goal };
        
        var paths = Mutable.Solve(maze, start, goal);
        
        Assert.That(paths, Has.One.EqualTo(new MutablePath { start, middle, goal }));
    }
}