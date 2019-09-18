using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DepartmentID { get; set; }
        public int BranchID { get; set; }
        public string DepartmentName { get; set; }
        public string Description { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }

        public virtual IEnumerable<Branch> Branch { get; set; }
        public virtual IEnumerable<Employee> Employee { get; set; }
        public virtual IEnumerable<Education> Education { get; set; }
    }
}
