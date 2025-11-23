# Data Structures Workspace

This workspace contains simple implementations of common data structures in `DataStructures` project and unit tests in `Tests` project.

Examples:

Stack
```
var s = new DataStructures.Stack<int>();
s.Push(1);
s.Push(2);
var top = s.Pop(); // 2
```

Queue
```
var q = new DataStructures.Queue<int>();
q.Enqueue(1);
q.Enqueue(2);
var first = q.Dequeue(); // 1
```

LinkedList
```
var list = new DataStructures.LinkedList<int>();
list.AddLast(1);
list.AddFirst(0);
```

Run tests using dotnet test in the solution directory.
