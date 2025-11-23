using System.Collections.Generic;

namespace DataStructures;

public class HashMap<TKey, TValue> where TKey : notnull
{
    private readonly Dictionary<TKey, TValue> _dict = [];

    public int Count => _dict.Count;

    public void Put(TKey key, TValue value) => _dict[key] = value;

    public bool TryGet(TKey key, out TValue? value) => _dict.TryGetValue(key, out value!);

    public bool Remove(TKey key) => _dict.Remove(key!);

    public void Clear() => _dict.Clear();
}
