using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using System.Linq;

namespace HumanResource.Business
{
    public class DepartmentService
    {
        private readonly IEmployee _employee;
        private readonly IDepartment _department;
        public DepartmentService(IEmployee employee, IDepartment department)
        {
            _employee = employee;
            _department = department;
        }

        public Department GetDepartmentByEmployeeId(int employeeId)
        {
            return _department.GetAll()
                  .FirstOrDefault(x => x.EmployeeId == employeeId);

            
        }

    }
}
