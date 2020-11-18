namespace CollectionHierarchy
{
    public class MyList<T> : Collection<T>
    {
        public int Add(T item)
        {
            this.items.Insert(0, item);
            return 0;
        }

        public T Remove()
        {
            T removedItem = this.items[0];
            this.items.RemoveAt(0);
            return removedItem;
        }
    }
}
