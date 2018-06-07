using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Collections
{
    public class ConsultantsFilter
        {
            private IEnumerable<Consultant> enumerator;

            public ConsultantsFilter()
            {
                enumerator = new Consultants().People;
            }

            public ConsultantsFilter ByProject(string project)
            {
                enumerator = enumerator.Where(c => c.Project.Equals(project));
                return this;
            }

            public ConsultantsFilter ByRol(string rol)
            {
                enumerator = enumerator.Where(c => c.Rol.Equals(rol));
                return this;
            }

            public ConsultantsFilter BySquad(int squad)
            {
                enumerator = enumerator.Where(c => c.Squad.Equals(squad));
                return this;
            }

            public IEnumerable<Consultant> Get()
            {
                return enumerator;
            }
          
        }
}