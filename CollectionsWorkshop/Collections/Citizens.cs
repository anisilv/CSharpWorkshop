namespace Collections
{
    public class Citizens
    {
        public Citizens()
        {
            _citizens = new string[,]
                {
                    {"1617898743","Robero"},
                    {"1633898743","Robero"},
                    {"1789871321","Tex"},
                    {"1716871323","Mauricio"},
                    {"1719861322","Anita"},
                    {"1719861323","Albero"},
                    {"1719861325","Migue"},
                    {"1712861322","Eduardo"},
                    {"1715861322","Luisitoff"}, 
                    {"1712891322","Eduardo"},
                    {"1715861222","Orlan-di-to"},
                    {"1717861322","Slin"}
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