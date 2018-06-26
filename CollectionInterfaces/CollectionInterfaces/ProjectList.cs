using System.Collections;
using System.Collections.Generic;
using Domain;

namespace CollectionInterfaces
{
    public class SquadProjects : IList<Project>
    {
        private IList<Project> _items;

        public SquadProjects()
        {
            _items = new List<Project>();
        }

        public Project this[int index] { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public int Count => _items.Count; 

        public bool IsReadOnly => throw new System.NotImplementedException();

        public void Add(Project item)
        {
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

        public int IndexOf(Project item)
        {
            throw new System.NotImplementedException();
        }

        public void Insert(int index, Project item)
        {
            throw new System.NotImplementedException();
        }

        public bool Remove(Project item)
        {
            throw new System.NotImplementedException();
        }

        public void RemoveAt(int index)
        {
            throw new System.NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _items.GetEnumerator();
        }
    }
}