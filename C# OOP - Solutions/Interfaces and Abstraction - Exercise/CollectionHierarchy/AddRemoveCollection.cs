namespace CollectionHierarchy
{
    public class AddRemoveCollection<T> : Collection<T>, IAddRemoveCollection<T>
    {
        public int Add(T item)
        {
            this.items.Insert(0, item);
            return 0;
        }

        public T Remove()
        {
            T removedItem = this.items[this.items.Count - 1];
            this.items.RemoveAt(this.items.Count - 1);
            return removedItem;
        }
    }
}
