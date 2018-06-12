using System.Collections.Generic;
using Domain;
using Repository;

namespace Collections.Test
{
    public class ConsultantsRepositoryTest : IConsultantsRepositoryRefactored
    {
        public List<Consultant> GetConsultants()
        {
            return new List<Consultant>
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
    }  
}