using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IEducation
    {

        IEnumerable<Education> GetAll();

        Education GetById(int id);

        bool Add(Education education);

        bool Update(Education education);

        bool Delete(Education education);

        bool Delete(int id);

    }
}
