using Xunit;
using DataStructures;
using DS = DataStructures;
using System.Linq;

namespace Tests;

public class BinarySearchTreeTests
{
    [Fact]
    public void InsertAndContains_Works()
    {
        var bst = new DS.BinarySearchTree<int>();
        bst.Insert(5);
        bst.Insert(3);
        bst.Insert(7);
        bst.Insert(4);

        Assert.True(bst.Contains(4));
        Assert.False(bst.Contains(6));

        var ordered = bst.InOrder().ToArray();
        Assert.Equal(new[] { 3, 4, 5, 7 }, ordered);
    }
}
