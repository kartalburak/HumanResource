using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("EmployeeRating")]
    public class EmployeeRating
    {
        [Key]
        public int EmployeeRatingId { get; set; }
        [MaxLength(Int32.MaxValue)]
        public string EmployeeRatingEvaluative { get; set; }
        public DateTime EmployeeRatingRateDate { get; set; } 
        [MaxLength(Int32.MaxValue)]
        public string EmployeeRatingResult { get; set; }
        [DefaultValue(1)]
        public bool EmployeeRatingStatus { get; set; }
        [DefaultValue(0)]
        public bool EmployeeIsDeleted { get; set; }


        public virtual Employee Employee { get; set; }


    }
}
