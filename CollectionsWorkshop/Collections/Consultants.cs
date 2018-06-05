using System;

namespace Collections
{
    public class Consultants
    {
         enum Columns{
                name = 0,
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
            int dimension = 0;

            for (int i = 0; i < People.GetLength(dimension); i++){
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
            const int dimension = 0;
            
            for (int i = 0; i < People.GetLength(dimension); i++){
                if(project == People[i,(int)Columns.project])
                {
                    consultants[consultantCont]=People[i,(int)Columns.name];
                    consultantCont++;
                }
            }

            Array.Resize(ref consultants,consultantCont);
            return consultants; 
        }

        public int GetNumberConsultantsByRol(string rol)
        {
            var consultantCont = 0;

            const int dimension = 0;
            for (int i = 0; i < People.GetLength(dimension); i++){
                if(rol == People[i,(int)Columns.rol])
                    consultantCont++;    
            }

            return consultantCont;
        }
    }
}