using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Department")]
    public class Department
    {
        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }
        [MaxLength(100)]
        [Required]
        public string DepartmentName { get; set; }
        [MaxLength(200)]
        public string DepartmentDescription { get; set; }
        [MaxLength(100)]
        public string DepartmentManager { get; set; }
        [DefaultValue(1)]
        public bool DepartmentStatus { get; set; }
        [DefaultValue(0)]
        public bool DepartmentIsDeleted { get; set; }

        public virtual ICollection<ActivityDepartment> ActivityDepartments { get; set; }
        public virtual ICollection<DepartmentEducation> DepartmentEducations { get; set; }
        public virtual ICollection<BranchDepartment> BranchDepartments { get; set; }
        public virtual ICollection<AdvertisementDepartment> AdvertisementDepartments { get; set; }
        public virtual ICollection<AnnouncementDepartment> AnnouncementDepartments { get; set; }
        public virtual IEnumerable<Employee> Employee { get; set; }
    }

    public class DepartmentEducation
    {

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int EducationId { get; set; }
        public Education Education { get; set; }
    }

}
