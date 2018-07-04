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
            foreach(var item in People)
            {
                if(project == item.Project)
                {
                    consultants[consultantCont]=item.Name;
                    consultantCont++;
                }
            }

            Array.Resize(ref consultants,consultantCont);
            return consultants; 
        }

        public int GetNumberConsultantsByRol(string role)
        {
            var consultantCont = 0;

            foreach(var item in People)
            {
                if(role == item.Role)
                    consultantCont++;    

            }

            return consultantCont;

        }
    }
}