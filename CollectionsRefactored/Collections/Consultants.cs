using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain;

namespace Collections
{
    public class Consultants
    {
           public Consultants()
        {
            People = new List<Consultant>
            {
                new Consultant.Builder().WithName("Albero")
                                    .WithProject("TradeMaster")
                                    .WithSquad1AndRolDev()
                                    .WithId("GG-01")
                                    .Build(),
                new Consultant{Name = "Robero A.", Squad = 2, Project ="Octopus",Rol = "DEV",Id = "GG-02"},
                new Consultant{Name = "Tex", Squad = 2, Project ="IB.Project.UI",Rol = "DEV",Id = "GG-03"},
                new Consultant{Name = "Mauri",Squad = 2, Project ="Deployment Advocate",Rol = "DEV",Id = "GG-04"},
                new Consultant{Name = "Anita",Squad = 2, Project ="IBMS",Rol = "DEV",Id = "GG-05"},
                new Consultant{Name = "Migue",Squad = 1, Project ="DocuSign",Rol = "DEV",Id = "GG-06"},
                new Consultant{Name = "Robero C.",Squad = 1,Project ="Factset",Rol = "DEV",Id = "GG-07"},
                new Consultant{Name = "Eduardo",Squad = 1,Project ="TradeMaster",Rol = "DEV",Id = "GG-08"},
                new Consultant{Name = "Luisitoff",Squad = 2,Project ="IB.Project.UI",Rol = "DEV",Id = "GG-09"},
                new Consultant{Name = "Orlan-di-to",Squad = 3,Project ="Sentry", Rol = "BA",Id = "GG-10"},
                new Consultant{Name = "Slin",Squad = 1,Project ="Sentry",Rol = "DEV", Id = "GG-11"}
            };
        }

        public List<Consultant> People{get; set;}

        public int GetNumberConsultantsBySquad(int squad)
        {
            return People.Count(c => c.Squad.Equals(squad));
        }

        public int GetNumberConsultantsByProject(string project)
        {
            return GetConsultantsByProject(project).Length;
        }

        public string[] GetConsultantsByProject(string project)
        {
            var consultants = People.Where(consultant => consultant.Project.Equals(project)); 
            return consultants.Select(c => c.Name).ToArray(); 
        }

        public int GetNumberConsultantsByRol(string rol)
        {
            return People.Count(c => c.Rol.Equals(rol));
        }

        public Filter filter => new Filter();
        public class Filter
        {
            private IEnumerable<Consultant> enumerator;

            public Filter()
            {
                enumerator = new Consultants().People;
            }

            public Filter ByProject(string project)
            {
                enumerator = enumerator.Where(c => c.Project.Equals(project));
                return this;
            }

            public Filter ByRol(string rol)
            {
                enumerator = enumerator.Where(c => c.Rol.Equals(rol));
                return this;
            }

            public Filter BySquad(int squad)
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
}