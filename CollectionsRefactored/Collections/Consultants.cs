using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Domain;
using Repository;

namespace Collections
{
    public class Consultants
    {
        private IConsultantsRepositoryRefactored _repository;
        public Consultants(IConsultantsRepositoryRefactored repository)
        {
            People = repository.GetConsultants();
            _repository = repository;
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

        public ConsultantsFilter filter => new ConsultantsFilter(_repository);
        
    }
}