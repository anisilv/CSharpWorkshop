namespace Collections
{
    public class Citizens
    {
        public Citizens()
        {
            _citizens = new string[,]
                {
                    {"1617898743","Robero","GG-02"},
                    {"1633898743","Robero","GG-01"},
                    {"1789871321","Tex","GG-03"},
                    {"1716871323","Mauri","GG-04"},
                    {"1719861322","Anita","GG-05"},
                    {"1719861323","Albero","GG-01"},
                    {"1719861325","Migue","GG-06"},
                    {"1712861322","Eduardo","GG-08"},
                    {"1715861322","Luisitoff","GG-09"}, 
                    {"1715861222","Orlan-di-to","GG-10"},
                    {"1717861322","Slin","GG-11"}
                };
        }

        private string[,] _citizens;

        public string GetById(string id)
        {
            const int dimension = 0;
            const int columnId = 0;
            const int columnName = 1;

            for (int i = 0; i < _citizens.GetLength(dimension); i++)      
                if (id == _citizens[i, columnId])
                    return _citizens[i, columnName];

            return string.Empty;
        }
    }
}