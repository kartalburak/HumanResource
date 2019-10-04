using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HumanResource.Business
{
    public class EducationService
    {
        private readonly IEmployee _employee;
        private readonly IEducation _education;
        public EducationService(IEmployee employee, IEducation education)
        {
            _employee = employee;
            _education = education;
        }

        public IEnumerable<Education> GetEducationByEmployeeId(int employeeId)
        {
            return _education.GetAll().Where(x => x.EducationEmployees.Select(y => y.EmployeeId).FirstOrDefault() == employeeId)
                .ToList();

        }
    }
}
