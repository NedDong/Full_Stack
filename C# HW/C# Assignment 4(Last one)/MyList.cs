namespace LastHW;

public class MyList<T>
{
    private List<T> list = new List<T>();
    public void add(T element)
    {
        list.Add(element);
    }

    public T Remove(int index)
    {
        T removedObject = list[index]; 
        list.RemoveAt(index);
        return removedObject;
    }

    public bool Contains(T element)
    {
        return list.Contains(element);
    }

    void Clear()
    {
        list.Clear();
    }

    void InsertAt(T element, int index)
    {
        list.Insert(index, element);
    }

    void DeleteAt(int index)
    {
        list.RemoveAt(index);
    }

    T Find(int index)
    {
        return list[index];
    }
}