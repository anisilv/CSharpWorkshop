using System.Collections;
using System.Collections.Generic;
using Domain;

namespace CollectionInterfaces
{
    public class Projects : IEnumerable<Project>
    {
        public IEnumerator<Project> GetEnumerator()
        {
            return null ;//mylist.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}