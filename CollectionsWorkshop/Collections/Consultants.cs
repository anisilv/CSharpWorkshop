using System;

namespace Collections
{
    public class Consultants
    {
         enum Columns{
                name = 0,
                squad = 1,
                project = 2,
                rol = 3,
                id = 4
            }

        public Consultants()
        {
            People = new string[,]
            {
                {"Albero","1", "TradeMaster","DEV","GG-01"},
                {"Robero A.", "2","Octopus","DEV","GG-02"},
                {"Tex","2", "IB.Project.UI","DEV","GG-03"},
                {"Mauri","2", "Deployment Advocate","DEV","GG-04"},
                {"Anita","2", "IBMS","DEV","GG-05"},
                {"Migue","1", "DocuSign","DEV","GG-06"},
                {"Robero C.","1","Factset","DEV","GG-07"},
                {"Eduardo","1","TradeMaster","DEV","GG-08"},
                {"Luisitoff","2","IB.Project.UI","DEV","GG-09"},
                {"Orlan-di-to","3","Jira","BA","GG-10"},
                {"Slin","1","Sentry","DEV","GG-11"}
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