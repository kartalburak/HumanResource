using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IPermit
    {
        IEnumerable<Permit> GetAll();

        Permit GetById(int id);

        bool Add(Permit permit);

        bool Update(Permit permit);

        bool Delete(Permit permit);

        bool Delete(int id);


    }
}
