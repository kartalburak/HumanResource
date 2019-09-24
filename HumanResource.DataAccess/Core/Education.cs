using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Education")]
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        [MaxLength(100)]
        [Required]
        public string EducationName { get; set; }
        [Required]
        public DateTime EducationBeginDate { get; set; }
        [Required]
        public DateTime EducationEndDate { get; set; }
        [Required]
        public int EducationCapacity { get; set; }
        [MaxLength(100)]
        public string EducationTrainerTitle { get; set; }
        [MaxLength(50)]
        public string EducationTrainerName { get; set; }
        [MaxLength(50)]
        public string EducationTrainerSurname { get; set; }
        [MaxLength(11)]
        public string EducationTrainerTelephone { get; set; }
        [MaxLength(Int32.MaxValue)]
        public string EducationsNotes { get; set; }
        public bool EducationIsMandatory { get; set; }
        [DefaultValue(1)]
        public bool EducationStatus { get; set; }
        [DefaultValue(0)]
        public bool EducationIsDeleted { get; set; }

        public virtual ICollection<EducationEmployee> EducationEmployees { get; set; }
        public virtual ICollection<DepartmentEducation> DepartmentEducations { get; set; }
        public virtual ICollection<BranchEducation> BranchEducations { get; set; }


        
    }

    public class EducationEmployee
    {

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
    }
}
