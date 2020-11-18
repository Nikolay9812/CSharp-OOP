namespace CollectionHierarchy
{
    public class AddCollection<T> : Collection<T>, IAddCollection<T>
    {
        public int Add(T item)
        {
            this.items.Add(item);
            return this.items.Count - 1;
        }
    }
}
