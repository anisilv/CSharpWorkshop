using System.Collections.Generic;
using Domain;

namespace Repository
{
    public interface IConsultantsRepository
    {
         string[,] GetConsultants();
    }

    public interface IConsultantsRepositoryRefactored
    {
         List<Consultant> GetConsultants();
    }
}