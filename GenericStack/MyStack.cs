using System;
using System.Collections.Generic;

class MyStack<T>
{
    private T[] _items;
    private int _count;

    public int Count => _count;
    public bool IsEmpty => _count == 0;

    public MyStack(int capacity)
    {
        _items = new T[capacity];
        _count = 0;
    }

    public void Push(T item)
    {
        _items[_count] = item;
        _count++;
    }

    public T Pop()
    {
        _count--;
        T item = _items[_count];
        _items[_count] = default(T);
        return item;
    }

    public T Peek()
    {
        return _items[_count - 1];
    }
}