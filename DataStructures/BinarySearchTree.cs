using System;
using System.Collections.Generic;

namespace DataStructures;

public class BSTNode<T> where T : IComparable<T>
{
    public T Value { get; set; }
    public BSTNode<T>? Left { get; set; }
    public BSTNode<T>? Right { get; set; }

    public BSTNode(T value) => Value = value;
}

public class BinarySearchTree<T> where T : IComparable<T>
{
    public BSTNode<T>? Root { get; private set; }
    public int Count { get; private set; }

    public void Insert(T value)
    {
        Root = Insert(Root, value);
        Count++;
    }

    private BSTNode<T> Insert(BSTNode<T>? node, T value)
    {
        if (node == null) return new BSTNode<T>(value);
        var cmp = value.CompareTo(node.Value);
        if (cmp < 0) node.Left = Insert(node.Left, value);
        else node.Right = Insert(node.Right, value);
        return node;
    }

    public bool Contains(T value) => Contains(Root, value);

    private bool Contains(BSTNode<T>? node, T value)
    {
        if (node == null) return false;
        var cmp = value.CompareTo(node.Value);
        if (cmp == 0) return true;
        return cmp < 0 ? Contains(node.Left, value) : Contains(node.Right, value);
    }

    public IEnumerable<T> InOrder()
    {
        var list = new List<T>();
        InOrder(Root, list);
        return list;
    }

    private void InOrder(BSTNode<T>? node, List<T> list)
    {
        if (node == null) return;
        InOrder(node.Left, list);
        list.Add(node.Value);
        InOrder(node.Right, list);
    }
}
