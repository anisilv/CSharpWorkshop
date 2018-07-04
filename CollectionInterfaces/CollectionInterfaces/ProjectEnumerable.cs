using System.Collections;
using System.Collections.Generic;
using Domain;

namespace CollectionInterfaces
{
    public class ProjectEnumerable : IEnumerable<Project>
    {
         private readonly IEnumerable<Project> _projects;

        public ProjectEnumerable(params Project[] projects)
        {
            _projects = projects;
        }

        public IEnumerator<Project> GetEnumerator()
        {
            foreach (var prj in _projects)
            {
                if (prj != null)
                {
                    yield return prj;
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int GetTotalOfProjects()
        {
            var result = 0;
            using (var e = GetEnumerator())
            {
                while (e.MoveNext())
                    result++;
            }
            return result;
        }
    }
}