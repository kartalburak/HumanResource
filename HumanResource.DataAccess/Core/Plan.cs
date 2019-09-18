using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Plan")]
    public class Plan
    {
        [Key]
        public int PlanID { get; set; }
        public DateTime PlanDate { get; set; }
        public string Subject { get; set; }
        public string FirstDate { get; set; }
        public string SecondDate { get; set; }
        public string ThirstData { get; set; }
        public string ForthDate { get; set; }
        public string FifthDate { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }




        public virtual IEnumerable<Branch> Branch { get; set; }
        public virtual IEnumerable<Department> Department { get; set; }
        public virtual IEnumerable<Employee> Employee { get; set; }

    }
}
