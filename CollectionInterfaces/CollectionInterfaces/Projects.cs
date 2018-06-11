using System.Collections;
using System.Collections.Generic;
using Domain;

namespace CollectionInterfaces
{
    public class Projects : IEnumerable<Project>
    {
        private Project _projectA,_projectB,_projectC;

        public Projects(Project projectA,Project projectB,Project projectC){

            this._projectA = projectA;
            this._projectB = projectB;
            this._projectC = projectC;
        }
        public IEnumerator<Project> GetEnumerator()
        {
            yield return _projectA;
            yield return _projectB;
            yield return _projectC;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public int Count(){
            int result = 0;

            using(var e  = GetEnumerator())
            {
                while (GetEnumerator().MoveNext())
                result++;
            }
            return result;
        }

    }
}