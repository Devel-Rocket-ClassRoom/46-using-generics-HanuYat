class Container<T>
{
    public T Item { get; set; }
}

class SpecialContainter<T> : Container<T>
{
    public string Description { get; set; }
}

class IntContainer : Container<int>
{
    public int Double() => Item * 2;
}