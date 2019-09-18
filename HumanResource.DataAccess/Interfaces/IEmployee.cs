using HumanResource.DataAccess.Core;
using System.Collections.Generic;
using System.Diagnostics;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IEmployee
    {

        IEnumerable<Employee> GetAll();

        Employee GetById(int id);

        bool Add(Employee employee);

        bool Update(Employee employee);

        bool Delete(Employee employee);

        bool Delete(int id);


    }
}
