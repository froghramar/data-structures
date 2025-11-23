using Xunit;
using DS = DataStructures;

namespace Tests;

public class LinkedListTests
{
    [Fact]
    public void AddAndRemove_Works()
    {
        var ll = new DS.LinkedList<int>();
        ll.AddLast(1);
        ll.AddLast(2);
        ll.AddFirst(0);
        Assert.Equal(3, ll.Count);
        Assert.Equal(0, ll.RemoveFirst());
        Assert.Equal(1, ll.RemoveFirst());
        Assert.Equal(2, ll.RemoveFirst());
        Assert.Equal(0, ll.Count);
    }
}
