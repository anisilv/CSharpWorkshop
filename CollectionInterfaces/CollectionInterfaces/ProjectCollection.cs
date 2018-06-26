using System.Collections;
using System.Collections.Generic;
using Domain;

namespace CollectionInterfaces
{
    public class ProjectCollection : ICollection<Project>
    {
        private const string projectAppend = "-Securities";
        ICollection<Project> _items;

        public ProjectCollection()
        {
            _items = new List<Project>();
        }

        public int Count => _items.Count;

        public bool IsReadOnly => throw new System.NotImplementedException();

        public void Add(Project item)
        {
            var newItem = item;
            item.Name = item.Name + projectAppend;
            _items.Add(item); 
        }

        public void Clear()
        {
            throw new System.NotImplementedException();
        }

        public bool Contains(Project item)
        {
            throw new System.NotImplementedException();
        }

        public void CopyTo(Project[] array, int arrayIndex)
        {
            throw new System.NotImplementedException(); 
        }

        public IEnumerator<Project> GetEnumerator()
        {
            return _items.GetEnumerator();
        }

        public bool Remove(Project item)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}