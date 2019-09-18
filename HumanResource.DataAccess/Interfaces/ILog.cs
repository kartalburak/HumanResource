using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface ILog
    {

        IEnumerable<Log> GetAll();

        Log GetById(int id);

        bool Add(Log log);

        bool Update(Log log);

        bool Delete(Log log);

        bool Delete(int id);
    }
}
