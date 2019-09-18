using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("EducationDetail")]
    public class EducationDetail
    {
        [Key]
        public int EducationDetailID { get; set; }
        [Required]
        public int EducationID { get; set; }
        public int EmployeeID { get; set; }
        public bool Status { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }








    }
}
