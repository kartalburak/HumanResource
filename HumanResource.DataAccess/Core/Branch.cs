using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Branch")]
    public class Branch
    {
        [ForeignKey("BranchId")]
        public int BranchId { get; set; }
        public int EmployeeId { get; set; }
        [Required]
        [MaxLength(100)]
        public string BranchName { get; set; }
        [MaxLength(20)]
        [Required]
        public string BranchCode { get; set; }
        [MaxLength(200)]
        public string BranchDescription { get; set; }
        [MaxLength(50)]
        [Required]
        public string BranchTelephone { get; set; }
        [MaxLength(500)]
        [Required]
        public string BranchAddress { get; set; }
        [MaxLength(100)]
        public string BranchFax { get; set; }
        [DefaultValue(1)]
        [Required]
        public bool BranchStatus { get; set; }
        [DefaultValue(0)]
        public bool BranchIsDeleted { get; set; }

        public virtual ICollection<ActivityBranch> ActivityBranches { get; set; }
        public virtual IEnumerable<JobApplication> JobApplication { get; set; }
        public virtual ICollection<BranchEducation> BranchEducations { get; set; }
        public virtual ICollection<BranchDepartment> BranchDepartments { get; set; }
        public virtual ICollection<AdvertisementBranch> AdvertisementBranches { get; set; }
        public virtual ICollection<AnnouncementBranch> AnnouncementBranches { get; set; }
        public virtual ICollection<Employee> Employee { get; set; }

    }


    public class BranchEducation
    {
            public int BranchId { get; set; }
            public Branch Branch { get; set; }
            public int EducationId { get; set; }
            public Education Education { get; set; }
    }
    public class BranchDepartment
    {
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
