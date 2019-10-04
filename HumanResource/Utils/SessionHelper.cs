using HumanResource.Business;
using HumanResource.DataAccess.Core;
using HumanResource.DataAccess.Interfaces;
using HumanResource.Models;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace HumanResource.Utils
{
    public static class SessionHelper
    {
        private static IHttpContextAccessor _httpContextAccessor;
        public static void Configure(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public static HttpContext CurrentHttpContext => _httpContextAccessor.HttpContext;


        public static void SetObject(this ISession session, string key, object value)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        public static SessionEmployee GetObject<SessionEmployee>(this ISession session, string key)
        {
            var value = session.GetString(key);
            return value == null ? default(SessionEmployee) : JsonConvert.DeserializeObject<SessionEmployee>(value);
        }

        public static SessionEmployee CurrentEmployee
        {
            get
            {

                if (CurrentHttpContext.Session.Get("HR_CurrentEmployee") == null)
                {
                    return null;
                }
                else
                {
                    return GetObject<SessionEmployee>(CurrentHttpContext.Session, "HR_CurrentEmployee");
                }
            }

            set
            {

                SetObject(CurrentHttpContext.Session, "HR_CurrentEmployee", value);
            }
        }


        public static SessionLoginResult Login(string userName, string userPassword, IEmployee employeeService, IDepartment departmentService, IEducation educationService, IMission missionService)
        {
            Employee IsEmployeeExist = new EmployeeService(employeeService, departmentService).CheckUsernameAndPassword(
                userName,
                userPassword);

            if (IsEmployeeExist != null)
            {

                Employee existEmployee = IsEmployeeExist;


                SessionEmployee currentEmployee = new SessionEmployee();
                currentEmployee.EmployeeId = existEmployee.EmployeeId;
                currentEmployee.EmployeeName = existEmployee.EmployeeName;
                currentEmployee.EmployeeSurname = existEmployee.EmployeeSurname;
                currentEmployee.EmployeeCode = existEmployee.EmployeeCode;
                currentEmployee.EmployeeEmail = existEmployee.EmployeeEmail;
                currentEmployee.EmployeeUsername = existEmployee.EmployeeUsername;
                currentEmployee.EmployeeTitle = existEmployee.EmployeeTitle;
                currentEmployee.EmployeeBirthdate = existEmployee.EmployeeBirthdate;
                currentEmployee.EmployeeTc = existEmployee.EmployeeTc;
                currentEmployee.EmployeeManager = existEmployee.EmployeeManager;

                currentEmployee.Departments = new DepartmentService(employeeService, departmentService).GetDepartmentByEmployeeId(existEmployee.EmployeeId);
                currentEmployee.Educations = new EducationService(employeeService, educationService).GetEducationByEmployeeId(existEmployee.EmployeeId);
                currentEmployee.Missions = new MissionService(employeeService, missionService).GetEducationByEmployeeId(existEmployee.EmployeeId);


                if (currentEmployee.Departments == null)
                {
                    return new SessionLoginResult(false, "Can not find departmant info from Human Resource system for employee.");
                }
                else if (currentEmployee.Educations == null)
                {
                    return new SessionLoginResult(false, "Can not find education info from Human Resource system for employee.");
                }
                else if (currentEmployee.Missions == null)
                {
                    return new SessionLoginResult(false, "Can not find missions info from Human Resource system for employee.");
                }



                CurrentEmployee = currentEmployee;

                return new SessionLoginResult(true, null);



            }
            else
            {
                return new SessionLoginResult(false, "Username or password wrong.");
            }


        }

        public static bool Logout()
        {

            if (CurrentHttpContext != null)
            {
                CurrentHttpContext.Session.Clear();
                foreach (var item in CurrentHttpContext.Session.Keys)
                {
                    CurrentHttpContext.Session.Remove(item);
                }
                return true;
            }
            else
            {
                return false;
            }





        }








    }
}
