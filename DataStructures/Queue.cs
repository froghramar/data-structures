using System;
using System.Collections.Generic;

namespace DataStructures;

public class Queue<T>
{
    private readonly System.Collections.Generic.LinkedList<T> _list = new();

    public int Count => _list.Count;
    public bool IsEmpty => Count == 0;

    public void Enqueue(T item) => _list.AddLast(item);

    public T Dequeue()
    {
        if (IsEmpty) throw new InvalidOperationException("Queue is empty");
        var value = _list.First!.Value;
        _list.RemoveFirst();
        return value;
    }

    public T Peek()
    {
        if (IsEmpty) throw new InvalidOperationException("Queue is empty");
        return _list.First!.Value;
    }

    public void Clear() => _list.Clear();
}
