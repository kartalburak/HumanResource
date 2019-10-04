using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HumanResource.Business
{
    public class EmployeeService
    {
        private readonly IEmployee _employee;
        private readonly IDepartment _department;
        public EmployeeService(IEmployee employee, IDepartment department)
        {
            _employee = employee;
            _department = department;
        }
        public IEnumerable<EmployeeListModel> GetEmployees()
        {
            IEnumerable<Employee> employees = _employee.GetAll().ToList();
            List<Department> departments = _department.GetAll().ToList();


            var model = from f in employees
                        select new EmployeeListModel()
                        {
                            Name = f.EmployeeName,
                            Surname = f.EmployeeSurname,
                            TCKN = f.EmployeeTc,
                            Telephone = f.EmployeeTelephone1,
                            Title = f.EmployeeTitle,
                            DepartmentName = f.Department.DepartmentName,
                            Manager = f.EmployeeManager,
                            Image = f.EmployeeImagePath
                        };


            /*
            var model2 = from f in employees
                        join d in departments on f.Department.DepartmentId equals d.DepartmentId
                        select new PersonelListModel()
                        {
                            Name = f.EmployeeName,
                            Surname = f.EmployeeSurname,
                            TCKN = f.EmployeeTc,
                            Telephone = f.EmployeeTelephone1,
                            Title = f.EmployeeTitle,
                            Department = d.DepartmentName,
                            Manager = f.EmployeeManager,
                            Image = f.EmployeeImagePath
                        };

    */

            return model;

        }

        public Employee GetEmployeeByUsername(string username)
        {
            if (string.IsNullOrEmpty(username)) return null;
            IEnumerable<Employee> employees = _employee.GetAll();
            return employees.FirstOrDefault(x => x.EmployeeUsername == username);


        }

        public Employee CheckUsernameAndPassword(string username, string password)
        {
            Employee employee = _employee.GetAll().Where(x => x.EmployeeUsername == username & x.EmployeePassword == password).FirstOrDefault();

            return employee == null ? null : employee;


        }
    }
}
