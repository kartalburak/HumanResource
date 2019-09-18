using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IPlan
    {


        IEnumerable<Plan> GetAll();

        Plan GetById(int id);

        bool Add(Plan plan);

        bool Update(Plan plan);

        bool Delete(Plan plan);

        bool Delete(int id);
    }
}
