using System.Collections.Generic;
using Domain;

namespace Repository
{
    public interface IConsultantsRepository
    {
         IEnumerable<Consultant> GetConsultants();
    }

    public interface IConsultantsRepositoryRefactored
    {
         List<Consultant> GetConsultants();
    }
}