using System.Collections.Generic;
using Domain;
using Repository;

namespace Collections.Test
{
    public class ConsultantsRepositoryDouble : IConsultantsRepository
    {
        public IEnumerable<Consultant> GetConsultants()
        {
            var consultants = new List<Consultant> {
                new Consultant() {
                    Name = "Albero",
                    Squad = 1,
                    Project = "TradeMaster",
                    Role = "DEV",
                    Id = "GG-01"
                },
                new Consultant() {
                    Name = "Robero A.", 
                    Squad = 2,
                    Project = "Octopus",
                    Role = "DEV",
                    Id = "GG-02"
                },
                new Consultant{Name = "Tex", Squad = 2, Project ="IB.Project.UI",Role = "DEV",Id = "GG-03"},
                new Consultant{Name = "Mauri",Squad = 2, Project ="Deployment Advocate",Role = "DEV",Id = "GG-04"},
                new Consultant{Name = "Anita",Squad = 2, Project ="IBMS",Role = "DEV",Id = "GG-05"},
                new Consultant{Name = "Migue",Squad = 1, Project ="DocuSign",Role = "DEV",Id = "GG-06"},
                new Consultant{Name = "Robero C.",Squad = 1,Project ="Factset",Role = "DEV",Id = "GG-07"},
                new Consultant{Name = "Eduardo",Squad = 1,Project ="TradeMaster",Role = "DEV",Id = "GG-08"},
                new Consultant{Name = "Luisitoff",Squad = 2,Project ="IB.Project.UI",Role = "DEV",Id = "GG-09"},
                new Consultant{Name = "Orlan-di-to",Squad = 3,Project ="Sentry", Role = "BA",Id = "GG-10"},
                new Consultant{Name = "Slin",Squad = 1,Project ="Sentry",Role = "DEV", Id = "GG-11"}
            };
            
            return consultants;
        }
    }
}