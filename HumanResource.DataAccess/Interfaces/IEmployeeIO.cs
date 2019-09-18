using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IEmployeeIO
    {

        IEnumerable<EmployeeIO> GetAll();

        EmployeeIO GetById(int id);

        bool Add(EmployeeIO employeeIo);

        bool Update(EmployeeIO employeeIo);

        bool Delete(EmployeeIO employeeIo);

        bool Delete(int id);


    }
}
