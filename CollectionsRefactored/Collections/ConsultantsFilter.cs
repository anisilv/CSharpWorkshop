using System.Collections.Generic;
using System.Linq;
using Domain;

namespace Collections
{
    public class ConsultantsFilter
        {
            private IEnumerable<Consultant> _consultantsFilter;

            public ConsultantsFilter()
            {
                _consultantsFilter = new Consultants().People;
            }

            public ConsultantsFilter ByProject(string project)
            {
                _consultantsFilter = _consultantsFilter.Where(c => c.Project.Equals(project));
                return this;
            }

            public ConsultantsFilter ByRol(string rol)
            {
                _consultantsFilter = _consultantsFilter.Where(c => c.Rol.Equals(rol));
                return this;
            }

            public ConsultantsFilter BySquad(int squad)
            {
                _consultantsFilter = _consultantsFilter.Where(c => c.Squad.Equals(squad));
                return this;
            }

            public IEnumerable<Consultant> Get()
            {
                return _consultantsFilter;
            }
          
        }
}