using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Activity")]
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        [ForeignKey("EmployeeId")]
        public int EmployeeId { get; set; }
        [MaxLength(100)]
        public string ActivityName { get; set; }
        [MaxLength(500)]
        public string ActivityDescription { get; set; }
        public DateTime ActivityDate { get; set; }
        public int ActivityCapacity { get; set; }
        public bool ActivityStatus { get; set; }
        public bool ActivityIsDeleted { get; set; }


        public virtual ICollection<ActivityEmployee> ActivityEmployees { get; set; }
        public virtual ICollection<ActivityBranch> ActivityBranches { get; set; }
        public virtual ICollection<ActivityDepartment> ActivityDepartments { get; set; }

    }


    public class ActivityEmployee
    {
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }



    }

    public class ActivityBranch
    {
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
    public class ActivityDepartment
    {
        public int ActivityId { get; set; }
        public Activity Activity { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }

}
