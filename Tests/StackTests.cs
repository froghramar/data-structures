using Xunit;
using DataStructures;
using DS = DataStructures;

namespace Tests;

public class StackTests
{
    [Fact]
    public void PushPop_Works()
    {
        var s = new DS.Stack<int>();
        Assert.True(s.IsEmpty);
        s.Push(1);
        s.Push(2);
        Assert.Equal(2, s.Count);
        Assert.Equal(2, s.Peek());
        Assert.Equal(2, s.Pop());
        Assert.Equal(1, s.Pop());
        Assert.True(s.IsEmpty);
    }

    [Fact]
    public void Pop_Empty_Throws()
    {
        var s = new DS.Stack<int>();
        Assert.Throws<System.InvalidOperationException>(new System.Action(() => s.Pop()));
    }
}
