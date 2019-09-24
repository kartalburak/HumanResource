using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Announcement")]
    public class Announcement
    {
        [Key]
        public int AnnouncementID { get; set; }
        [Required]
        [MaxLength(100)]
        public string AnnouncementName { get; set; }
        [Required]
        [MaxLength(100)]
        public string AnnouncementDescription { get; set; }
        [Required]
        public DateTime AnnouncementBeginDate { get; set; }
        [Required]
        public DateTime AnnouncementEndDate { get; set; }
        [Required]
        [MaxLength(100)]
        public string AnnouncementTitle { get; set; }
        [Required]
        [MaxLength(int.MaxValue)]
        public string AnnouncementContent { get; set; }
        [DefaultValue(1)]
        public bool AnnouncementStatus { get; set; }
        [DefaultValue(0)]
        public bool AnnouncementIsDeleted { get; set; }




        public virtual ICollection<AnnouncementEmployee> AnnouncementEmployees { get; set; }
        public virtual ICollection<AnnouncementBranch> AnnouncementBranches { get; set; }
        public virtual ICollection<AnnouncementDepartment> AnnouncementDepartments { get; set; }

    }

    public class AnnouncementEmployee
    {
        public int AnnouncementId { get; set; }
        public Announcement Announcement { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
    public class AnnouncementBranch
    {
        public int AnnouncementId { get; set; }
        public Announcement Announcement { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
    public class AnnouncementDepartment
    {
        public int AnnouncementId { get; set; }
        public Announcement Announcement { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }

}
