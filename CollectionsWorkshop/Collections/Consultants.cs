using System;

namespace Collections
{
    public class Consultants
    {
         enum Columns{
                nombre = 0,
                squad = 1,
                project = 2,
                rol = 3
            }

        public Consultants()
        {
            People = new string[,]
            {
                {"Albero","1", "TradeMaster","DEV"},
                {"Robero A.", "2","Octopus","DEV"},
                {"Tex","2", "IB.Project.UI","DEV"},
                {"Mauri","2", "Deployment Advocate","DEV"},
                {"Anita","2", "IBMS","DEV"},
                {"Migue","1", "DocuSign","DEV"},
                {"Robero C.","1","Factset","DEV"},
                {"Eduardo","1","TradeMaster","DEV"},
                {"Luisitoff","2","IB.Project.UI","DEV"},
                {"Orlan-di-to","3","Jira","BA"},
                {"Slin","1","Sentry","DEV"}
            };
        }

        public string[,] People{get; set;}

        public int GetNumberConsultantsBySquad(int squad){
            
            var consultantCont = 0;

            for (int i = 0; i < People.GetLength(0); i++){
                if(squad == Convert.ToInt32(People[i,(int)Columns.squad]))
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

            for (int i = 0; i < People.GetLength(0); i++){
                if(project == People[i,2])
                {
                    consultants[consultantCont]=People[i,(int)Columns.nombre];
                    consultantCont++;
                }
            }

            return consultants; 
        }

        public int GetNumberConsultantsByRol(string rol)
        {
            var consultantCont = 0;

            for (int i = 0; i < People.GetLength(0); i++){
                if(rol == People[i,(int)Columns.rol])
                    consultantCont++;    
            }

            return consultantCont;
        }
    }
}