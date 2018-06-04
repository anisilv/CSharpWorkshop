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
                    {"1719861322","Anita"}
                };
        }

        private string[,] _citizens;

        public string GetById(string id)
        {
           
            for (int i = 0; i < _citizens.GetLength(0); i++){
                if(id == _citizens[i,0])
                    return _citizens[i,1];    
            }

            return string.Empty;
        }
    }
}