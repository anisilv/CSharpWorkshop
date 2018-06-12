using System.Collections.Generic;

namespace Repository
{
    public interface IOfficeRepository
    {
         Dictionary<string,string> GetOffices();
    }
}