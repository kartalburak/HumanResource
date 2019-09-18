using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Reference")]
    public class Reference
    {

        [Key]
        public int ReferenceID { get; set; }
        public int JobApplicationID { get; set; }
        public int CompanyName { get; set; }
        public int NameSurname { get; set; }

        public int Address { get; set; }

        [Required]
        public string Phone { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }






    }
}
