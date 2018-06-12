using System;
using System.Collections.Generic;

namespace CollectionsKeyValue
{
    public class TWOffices
    {
        public Dictionary<string,string> Offices {get; set;}

        public TWOffices()
        {
            Offices = new Dictionary<string, string>
            {
                {"UIO","Quito"},
                {"Stgo","Santiago"},
                {"Rcf","Recife"},
                {"POA","Porto Alegre"},
                {"BH","Belo Horizonte"},
                {"SP","Sao Paulo"}
            };
        }

        public string GetOffice(string key)
        {
            string office;

            return Offices.TryGetValue(key,out office) ? office : throw new ArgumentException("This office not exist.");
        }
    }
}