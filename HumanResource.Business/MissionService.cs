using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace HumanResource.Business
{
    public class MissionService
    {
        private readonly IEmployee _employee;
        private readonly IMission _mission;
        public MissionService(IEmployee employee, IMission mission)
        {
            _employee = employee;
            _mission = mission;

        }

        public IEnumerable<Mission> GetEducationByEmployeeId(int employeeId)
        {
            return _mission.GetAll()
                .Where(x => x.EmployeeMissions.Select(y => y.EmployeeId).FirstOrDefault() == employeeId).ToList();
        }
    }
}
