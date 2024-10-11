namespace LastHW;

public class GenericRepository<T> : IRepository<T> where T : Entity
{
    private List<T> list = new List<T>();
    public void Add(T item)
    {
        list.Add(item);
    }

    public void Remove(T item)
    {
        list.Remove(item);
    }

    public void Save()
    {
        throw new NotImplementedException();
    }

    public IEnumerable<T> GetAll()
    {
        return list;
    }

    public T GetById(int id)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].ID == id)
            {
                return list[i];
            }
        }

        return null;
    }
    
}