using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace HumanResource.DataAccess.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private readonly HumanResourceContext _humanResourceContext;
        public EmployeeRepository(HumanResourceContext humanResourceContext)
        {
            _humanResourceContext = humanResourceContext;
        }

        public bool Add(Employee employee)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Employee employee)
        {
            try
            {
                _humanResourceContext.Employees.Remove(employee);
                _humanResourceContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);//Logger eklenicek
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                _humanResourceContext.Employees.Remove(_humanResourceContext.Employees.Find(id));
                _humanResourceContext.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return false;
            }
        }

        public IEnumerable<Employee> GetAll()
        {

            return _humanResourceContext.Employees.AsNoTracking().ToList();

        }

        public Employee GetById(int id)
        {
            return _humanResourceContext.Employees.Find(id);
        }

        public bool Update(Employee employee)
        {
            throw new NotImplementedException();
        }

    }
}
