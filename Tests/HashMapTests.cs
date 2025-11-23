using Xunit;
using DataStructures;
using DS = DataStructures;

namespace Tests;

public class HashMapTests
{
    [Fact]
    public void PutGet_Remove_Works()
    {
        var map = new DS.HashMap<string, int>();
        map.Put("one", 1);
        map.Put("two", 2);
        Assert.Equal(2, map.Count);
        Assert.True(map.TryGet("one", out var v1));
        Assert.Equal(1, v1);
        Assert.True(map.Remove("one"));
        Assert.False(map.TryGet("one", out _));
    }
}
