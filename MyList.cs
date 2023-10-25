public class MyList<T>
{
    private T[] _elements;
    private int _count;
    public int Count { get => _count; }

    public MyList()
    {
        _elements = new T[4];
        _count = 0;
    }

    public T this[int index]
    {
        get
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            return _elements[index];
        }
        set
        {
            if (index < 0 || index >= _count)
            {
                throw new IndexOutOfRangeException();
            }
            _elements[index] = value;
        }
    }

    public void Add(params T[] items)
    {
        foreach (T item in items)
        {
            if (_count == _elements.Length)
            {
                Array.Resize(ref _elements, _elements.Length * 2);
            }
            _elements[_count] = item;
            _count++;
        }
    }


    public void Insert(int index, T item)
    {
        if (_count == _elements.Length)
        {
            Array.Resize(ref _elements, _elements.Length * 2);
        }
        for (int i = _count; i > index; i--)
        {
            _elements[i] = _elements[i - 1];
        }
        _elements[index] = item;
        _count++;
    }

    public void Remove(T item)
    {
        int index = Array.IndexOf(_elements, item);
        if (index >= 0)
        {
            RemoveAt(index);
        }
    }

    public void RemoveAt(int index)
    {
        for (int i = index; i < _count - 1; i++)
        {
            _elements[i] = _elements[i + 1];
        }
        _count--;
        if (_count <= _elements.Length / 4)
        {
            Array.Resize(ref _elements, _elements.Length / 2);
        }
    }

    public void Clear()
    {
        _elements = new T[4];
        _count = 0;
    }

    public void Sort()
    {
        Array.Sort(_elements, 0, _count);
    }
}
