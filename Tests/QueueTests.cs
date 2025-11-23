using Xunit;
using DataStructures;
using DS = DataStructures;

namespace Tests;

public class QueueTests
{
    [Fact]
    public void EnqueueDequeue_Works()
    {
        var q = new DS.Queue<string>();
        Assert.True(q.IsEmpty);
        q.Enqueue("a");
        q.Enqueue("b");
        Assert.Equal(2, q.Count);
        Assert.Equal("a", q.Peek());
        Assert.Equal("a", q.Dequeue());
        Assert.Equal("b", q.Dequeue());
        Assert.True(q.IsEmpty);
    }

    [Fact]
    public void Dequeue_Empty_Throws()
    {
        var q = new DS.Queue<int>();
        Assert.Throws<System.InvalidOperationException>(new System.Action(() => q.Dequeue()));
    }
}
