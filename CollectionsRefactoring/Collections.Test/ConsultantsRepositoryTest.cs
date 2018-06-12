using Repository;

namespace Collections.Test
{
    public class ConsultantsRepositoryTest : IConsultantsRepository
    {
        public string[,] GetConsultants()
        {
            return new string[,]
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
    }
}