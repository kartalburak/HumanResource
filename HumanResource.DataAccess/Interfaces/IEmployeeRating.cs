using HumanResource.DataAccess.Core;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Interfaces
{
    public interface IEmployeeRating
    {


        IEnumerable<EmployeeRating> GetAll();

        EmployeeRating GetById(int id);

        bool Add(EmployeeRating employeeRating);

        bool Update(EmployeeRating employeeRating);

        bool Delete(EmployeeRating employeeRating);

        bool Delete(int id);



    }
}
