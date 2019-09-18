using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Permit")]
    public class Permit
    {
        [Key]
        public int PermitID { get; set; }
        public int PersonalID { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Reason { get; set; }
        public DateTime RequestDate { get; set; }
        public string DepartmentManager { get; set; }
        public DateTime DProcessDate { get; set; }
        public string DNote { get; set; }
        public bool DConfirm { get; set; }
        public string HRManager { get; set; }
        public DateTime HRProcessDate { get; set; }
        public string HRNote { get; set; }
        public bool HRConfirm { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }
    }
}
