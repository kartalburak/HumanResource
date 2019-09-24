using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Permit")]
    public class Permit
    {
        [Key]
        public int PermitId { get; set; }
        public DateTime PermitBeginDate { get; set; }
        public DateTime PermitEndDate { get; set; }
        [MaxLength(Int32.MaxValue)]
        public string PermitReason { get; set; }
        public DateTime PermitRequestDate { get; set; }
        public bool PermitConfirm { get; set; }
        [MaxLength(Int32.MaxValue)]
        public string PermitNotes { get; set; }
        [DefaultValue(1)]
        public bool PermitStatus { get; set; }
        [DefaultValue(0)]
        public bool PermitIsDeleted { get; set; }


        public virtual ICollection<EmployeePermit> EmployeePermits { get; set; }

    }
}
