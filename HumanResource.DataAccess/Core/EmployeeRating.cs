using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("PersonalRating")]
    public class EmployeeRating
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public int PersonalID { get; set; }
        public DateTime RateDate { get; set; }
        public string Evaluative { get; set; } //değerlendiren

        public string Result { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }


    }
}
