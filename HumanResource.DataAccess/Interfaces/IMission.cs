using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IMission
    {


        IEnumerable<Mission> GetAll();

        Mission GetById(int id);

        bool Add(Mission mission);

        bool Update(Mission mission);

        bool Delete(Mission mission);

        bool Delete(int id);
    }
}
