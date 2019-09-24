using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Reference")]
    public class Reference
    {

        [Key]
        public int ReferenceID { get; set; }
        [MaxLength(100)]
        [Required]
        public string ReferenceName { get; set; }
        [MaxLength(100)]
        [Required]
        public string ReferenceSurname { get; set; }
        [MaxLength(100)]
        [Required]
        public string ReferenceCompanyName { get; set; }
        [MaxLength(int.MaxValue)]
        public string ReferenceAddress { get; set; }
        [Required]
        [MaxLength(11)]
        public string ReferenceTelephone { get; set; }
        [Required]
        [MaxLength(100)]
        public string ReferenceTitle { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }


        public virtual ICollection<EmployeeReference> EmployeeReferences { get; set; }
        public virtual ICollection<JobApplicationReference> JobApplicationReferences { get; set; }


    }
}
