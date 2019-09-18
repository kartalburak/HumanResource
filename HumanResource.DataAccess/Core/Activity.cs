using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Activity")]
    public class Activity
    {
        [Key]
        public int ActivityID { get; set; }
        public int BranchID { get; set; }
        public int DepartmentID { get; set; }

        public string ActivityName { get; set; }
        public string ActivityDescription { get; set; }
        public DateTime ActivityDate { get; set; }
        public int Capacity { get; set; }
        public bool IsDeleted { get; set; }


        public virtual List<Employee> Employee { get; set; }
        public virtual List<Branch> Branch { get; set; }
        public virtual List<Department> Department { get; set; }
    }
}
