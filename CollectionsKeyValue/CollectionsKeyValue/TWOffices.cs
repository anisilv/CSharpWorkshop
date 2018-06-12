using System;
using System.Collections.Generic;
using Repository;

namespace CollectionsKeyValue
{
    public class TWOffices
    {
        public Dictionary<string,string> Offices {get; set;}

        public TWOffices(IOfficeRepository repository)
        {
            Offices = repository.GetOffices(); 
        }

        public string GetOffice(string key)
        {
            string office;

            return Offices.TryGetValue(key,out office) ? office : throw new ArgumentException("This office not exist.");
        }
    }
}