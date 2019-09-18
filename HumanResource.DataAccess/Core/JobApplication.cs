using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("JobApplication")]
    public class JobApplication
    {
        [Key]
        public int ApplicationID { get; set; }
        public int UserID { get; set; }
        public string NameSurname { get; set; }
        public string Birthplace { get; set; }
        public DateTime Birthdate { get; set; }
        public string Gender { get; set; }
        public string ChildNumber { get; set; }
        public string ChildAge { get; set; }
        public string WifeName { get; set; }
        public string WifeEducation { get; set; }
        public string WifeJob { get; set; }
        public string WifeJobAddress { get; set; }
        public string JobPhone { get; set; }
        public string HomePhone { get; set; }
        public string Phone { get; set; }
        public string Nationality { get; set; }
        public string MilitaryStatus { get; set; }
        public bool IsDrivingLicense { get; set; }
        public string LicenseClass { get; set; }
        public bool IsCriminalRecord { get; set; }
        public DateTime LicenseDate { get; set; }

        public string SchoolName { get; set; }
        public string SchoolCity { get; set; }
        public string SchoolDegree { get; set; }
        public double ExpectedSalary { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }

        
        
        

    }
}
