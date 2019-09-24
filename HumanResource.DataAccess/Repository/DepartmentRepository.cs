using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using System.Collections.Generic;

namespace HumanResource.DataAccess.Repository
{
    public class DepartmentRepository : IDepartment
    {
        private readonly HumanResourceContext _humanResourceContext;
        public DepartmentRepository(HumanResourceContext humanResourceContext)
        {
            _humanResourceContext = humanResourceContext;
        }
        public bool Add(Department department)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(Department department)
        {
            throw new System.NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Department> GetAll()
        {
            return _humanResourceContext.Departments;
        }

        public Department GetById(int id)
        {
            return _humanResourceContext.Departments.Find(id);
        }

        public bool Update(Department department)
        {
            throw new System.NotImplementedException();
        }
    }
}
