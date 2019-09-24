using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Advertisement")]
    public class Advertisement
    {
        [Key]
        public int AdvertisementID { get; set; }
        [MaxLength(100)]
        public string AdvertisementTitle { get; set; }
        [MaxLength(100)]
        public string AdvertisementName { get; set; }
        public DateTime AdvertisementBeginDate { get; set; }
        public DateTime AdvertisementEndDate { get; set; }
        [MaxLength(int.MaxValue)]
        public string AdvertisementJobDescription { get; set; }
        [MaxLength(int.MaxValue)]
        public string AdvertisementDescription { get; set; }
        [MaxLength(500)]
        public string AdvertisementExperience { get; set; }
        [MaxLength(100)]
        public string AdvertisementEducationLevel { get; set; }
        [MaxLength(100)]
        public string AdvertisementPositionLevel { get; set; }      
        [MaxLength(50)]
        public string AdvertisementWayOfWorking { get; set; }
        public int AdvertisementPersonelNumber { get; set; }
        [MaxLength(50)]
        public string AdvertisementCountry { get; set; }
        [MaxLength(50)]
        public string AdvertisementCity { get; set; }
        [MaxLength(50)]
        public string AdvertisementMilitary { get; set; }
        public int AdvertisementViewsCount { get; set; }
        public bool AdvertisementIsStatus { get; set; }
        public bool AdvertisementIsDeleted { get; set; }



        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<AdvertisementBranch> AdvertisementBranches { get; set; }
        public virtual ICollection<AdvertisementDepartment> AdvertisementDepartments { get; set; }

    }

    //public class AdvertisementEmployee
    //{
    //    public int AdvertisementId { get; set; }
    //    public Advertisement Advertisement { get; set; }
    //    public int EmployeeId { get; set; }
    //    public Employee Employee { get; set; }
    //}
    public class AdvertisementBranch
    {
        public int AdvertisementId { get; set; }
        public Advertisement Advertisement { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
    }
    public class AdvertisementDepartment
    {
        public int AdvertisementId { get; set; }
        public Advertisement Advertisement { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }

}
