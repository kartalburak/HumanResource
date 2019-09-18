using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Advertisement")]
    public class Advertisement
    {
        [Key]
        public int AdvertisementID { get; set; }
        public string Description { get; set; }
        public string JobDescription { get; set; }
        public string Experience { get; set; }
        public bool Military { get; set; }
        public string EducationLevel { get; set; }
        public string WayOfWorking { get; set; }
        public string PozitionLevel { get; set; }
        public int PersonalNumber { get; set; }
        public string Country { get; set; }
        public string Department { get; set; }
        public string Sector { get; set; }
        public int views { get; set; }
        public int NumberOfApplication { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }


        public virtual IEnumerable<Branch> Branch { get; set; }


    }
}
