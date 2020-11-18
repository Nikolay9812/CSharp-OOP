using System.Collections.Generic;

namespace CollectionHierarchy
{
    public abstract class Collection<T>
    {
        private const int MaxSize = 100;
        protected List<T> items;

        protected Collection()
        {
            this.items = new List<T>(MaxSize);
        }
    }
}
