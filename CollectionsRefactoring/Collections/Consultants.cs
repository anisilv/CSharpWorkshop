using System;
using System.Collections.Generic;
using Domain;
using Repository;

namespace Collections
{
    public class Consultants
    {
        public Consultants(IConsultantsRepository repository)
        {
            People = repository.GetConsultants(); 
        }

        public IEnumerable<Consultant> People{get; set;}

        public int GetNumberConsultantsBySquad(int squad){
            
            var consultantCont = 0;

            foreach(var item in People)
            {
                if(squad == item.Squad)
                    consultantCont++;                    
            }
            return consultantCont;
        }

        public int GetNumberConsultantsByProject(string project)
        {
            return GetConsultantsByProject(project).Length;
        }

        public string[] GetConsultantsByProject(string project)
        {
            var consultantCont = 0;
            var consultants = new string[10];
            const int dimension = 0;
            
            var consultants = new List<>
            foreach(var item in People)
            {
                if(project == item.Project)
                    consultantCont++;                    
            }
            return consultantCont;

            for (int i = 0; i < People.GetLength(dimension); i++){
                if(project == People[i].Project)
                {
                    consultants[consultantCont]=People[i].Name;
                    consultantCont++;
                }
            }

            Array.Resize(ref consultants,consultantCont);
            return consultants; 
        }

        public int GetNumberConsultantsByRol(string role)
        {
            var consultantCont = 0;

            const int dimension = 0;
            for (int i = 0; i < People.GetLength(dimension); i++){
                if(role == People[i].Role)
                    consultantCont++;    
            }

            return consultantCont;
        }
    }
}