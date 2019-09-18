using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("SalaryPayment")]
    public class SalaryPayment
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int PersonalID { get; set; }
        public DateTime SalaryDate { get; set; }
        public float PrimPercentage { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }
    }
}
