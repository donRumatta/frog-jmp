using FrogJmp;

namespace Tests;

public class Tests
{
    [Test]
    public void Jump_Far()
    {
        var frog = new Frog(30, 10);

        var leaps = frog.Jump(85);
        
        Assert.AreEqual(3, leaps);
    }
    
    [Test]
    public void Jump_SamePlace()
    {
        var frog = new Frog(30, 10);

        var leaps = frog.Jump(10);
        
        Assert.AreEqual(0, leaps);
    }
}