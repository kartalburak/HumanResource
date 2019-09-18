using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IDepartment
    {
        IEnumerable<Department> GetAll();

        Department GetById(int id);

        bool Add(Department department);

        bool Update(Department department);

        bool Delete(Department department);

        bool Delete(int id);
    }
}
