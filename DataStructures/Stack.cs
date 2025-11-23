using System;
using System.Collections.Generic;

namespace DataStructures;

public class Stack<T>
{
    private readonly List<T> _items = new();

    public int Count => _items.Count;
    public bool IsEmpty => Count == 0;

    public void Push(T item) => _items.Add(item);

    public T Pop()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty");
        var idx = _items.Count - 1;
        var item = _items[idx];
        _items.RemoveAt(idx);
        return item;
    }

    public T Peek()
    {
        if (IsEmpty) throw new InvalidOperationException("Stack is empty");
        return _items[^1];
    }

    public void Clear() => _items.Clear();
}
