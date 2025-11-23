namespace DataStructures;

public class LinkedListNode<T>
{
    public T Value { get; set; }
    public LinkedListNode<T>? Next { get; set; }

    public LinkedListNode(T value) => Value = value;
}

public class LinkedList<T>
{
    public LinkedListNode<T>? Head { get; private set; }
    public LinkedListNode<T>? Tail { get; private set; }
    public int Count { get; private set; }

    public void AddLast(T value)
    {
        var node = new LinkedListNode<T>(value);
        if (Head == null)
        {
            Head = Tail = node;
        }
        else
        {
            Tail!.Next = node;
            Tail = node;
        }
        Count++;
    }

    public void AddFirst(T value)
    {
        var node = new LinkedListNode<T>(value);
        if (Head == null)
        {
            Head = Tail = node;
        }
        else
        {
            node.Next = Head;
            Head = node;
        }
        Count++;
    }

    public T? RemoveFirst()
    {
        if (Head == null) return default;
        var value = Head.Value;
        Head = Head.Next;
        if (Head == null) Tail = null;
        Count--;
        return value;
    }

    public void Clear()
    {
        Head = Tail = null;
        Count = 0;
    }
}
