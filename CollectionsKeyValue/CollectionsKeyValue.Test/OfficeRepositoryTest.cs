using System.Collections.Generic;
using Repository;

namespace CollectionsKeyValue.Test
{
    public class OfficeRepositoryTest : IOfficeRepository
    {
        public Dictionary<string, string> GetOffices()
        {
            return new Dictionary<string, string>
                        {
                            {"UIO","Quito"},
                            {"Stgo","Santiago"},
                            {"Rcf","Recife"},
                            {"POA","Porto Alegre"},
                            {"BH","Belo Horizonte"},
                            {"SP","Sao Paulo"}
                        };
        }
    }
}