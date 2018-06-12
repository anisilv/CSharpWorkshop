using System.Collections;
using System.Collections.Generic;
using Domain;

namespace CollectionInterfaces
{
    public class GugguenProjects : ICollection<Project>
    {
        private const string projectAppend = "-Securities";
        ICollection<Project> _items;

        public GugguenProjects()
        {
            _items = new List<Project>();
        }

        public int Count => _items.Count;

        public bool IsReadOnly => _items.IsReadOnly;

        public void Add(Project item)
        {
            var newItem = item;
            item.Name = item.Name + projectAppend;
            _items.Add(item); 
        }

        public void Clear()
        {
            _items.Clear();
        }

        public bool Contains(Project item)
        {
            return _items.Contains(item);
        }

        public void CopyTo(Project[] array, int arrayIndex)
        {
            _items.CopyTo(array, arrayIndex); 
        }

        public IEnumerator<Project> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public bool Remove(Project item)
        {
            return _items.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}