using System;
using System.Collections.Generic;

class Registry<TKey, TValue> where TKey : IEquatable<TKey>
{
    private List<TKey> _keys;
    private List<TValue> _values;
    private int _count;

    public int Count => _count;

    public Registry(int capacity)
    {
        _keys.Capacity = capacity;
        _values.Capacity = capacity;
        _count = 0;
    }
 
    public void Register(TKey key, TValue value)
    {
        _keys.Add(key);
        _values.Add(value);
        _count++;
    }

    public TValue Find(TKey key)
    {
        TValue find = default(TValue);

        for (int i = 0; i < _keys.Count; i++)
        {
            if (key == _keys[i])
            {
                find = _values[i];
            }
        }
        return find;
    }

    public bool Contains(TKey key)
    {
        if (_keys.Contains(key))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void PrintAll()
    {
        for (int i = 0; i < _keys.Count; ++i)
        {
            Console.WriteLine($"[{_keys[i]}] {_values[i]}");
        }
    }  
}