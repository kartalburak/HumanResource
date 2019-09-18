using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("SalaryIncrease")]
    public class SalaryIncrease
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int PersonalID { get; set; }
        public DateTime Date { get; set; }
        [Required]
        public float NewSalary { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }









    }
}
