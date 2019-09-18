using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Branch")]
    public class Branch
    {
        [Key]
        public int BranchID { get; set; }
        [Required]
        public string BranchName { get; set; }
        public string BranchCode { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }





        public virtual IEnumerable<Employee> Employee { get; set; }

    }
}
