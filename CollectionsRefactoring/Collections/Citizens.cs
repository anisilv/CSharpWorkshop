using Repository;

namespace Collections
{
    public class Citizens
    {
        public Citizens(ICitizenRepository repository)
        {
            _citizens = repository.GetCitizens();
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