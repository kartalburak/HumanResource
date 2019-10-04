using HumanResource.DataAccess.Core;
using System;
using System.Collections.Generic;

namespace HumanResource.Models
{
    public class SessionEmployee
    {

        public int EmployeeId { get; set; }
        public string EmployeeCode { get; set; }
        public string EmployeeUsername { get; set; }
        public string EmployeePassword { get; set; }
        public string EmployeeTitle { get; set; }
        public string EmployeeName { get; set; }
        public string EmployeeSurname { get; set; }
        public DateTime EmployeeBirthdate { get; set; }
        public string EmployeeEmail { get; set; }
        public string EmployeeTelephone1 { get; set; }
        public string EmployeeBloodGroup { get; set; }
        public string EmployeeTc { get; set; }
        public string EmployeeManager { get; set; }


        public Department Departments { get; set; }
        public IEnumerable<Education> Educations { get; set; }
        public IEnumerable<Mission> Missions { get; set; }


    }
}
