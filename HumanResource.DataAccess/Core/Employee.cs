using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public int IncapacityReportId { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Personel kodu zorunlu alandır. Boş geçilemez!")]
        public string EmployeeCode { get; set; }
        [MaxLength(50)]
        [Required(ErrorMessage = "Personel kullanıcı adı zorunlu alandır. Boş geçilemez!")]
        public string EmployeeUsername { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "Personel şifresi zorunlu alandır. Boş geçilemez!")]
        public string EmployeePassword { get; set; }
        [MaxLength(100)]
        [Required(ErrorMessage = "Personel ünvanı zorunlu alandır. Boş geçilemez!")]
        public string EmployeeTitle { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "Personel adı zorunlu alandır. Boş geçilemez!")]
        public string EmployeeName { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "Personel soyadı zorunlu alandır. Boş geçilemez!")]
        public string EmployeeSurname { get; set; }
        [Required(ErrorMessage = "Personel doğum tarihi zorunlu alandır. Boş geçilemez!")]
        public DateTime EmployeeBirthdate { get; set; }
        [MaxLength(30)]
        [Required(ErrorMessage = "Personel emaili zorunlu alandır. Boş geçilemez!")]
        public string EmployeeEmail { get; set; }
        [MaxLength(30)]
        public string EmployeeCompanyMail { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "Personel doğum yeri zorunlu alandır. Boş geçilemez!")]
        public string EmployeeBirthplace { get; set; }
        [MaxLength(15)]
        [Required(ErrorMessage = "Personel telefon numarası zorunlu alandır. Boş geçilemez!")]
        public string EmployeeTelephone1 { get; set; }
        [MaxLength(15)]
        public string EmployeeTelephone2 { get; set; }
        [Required(ErrorMessage = "Personel sigara bilgisi zorunlu alandır. Boş geçilemez!")]
        [DefaultValue(0)]
        public bool EmployeeIsSmoke { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "Personel kan grubu bilgisi zorunlu alandır. Boş geçilemez!")]
        public string EmployeeBloodGroup { get; set; }
        [MaxLength(11)]
        [Required(ErrorMessage = "Personel TC kimlik numrası zorunlu alandır. Boş geçilemez!")]
        public string EmployeeTc { get; set; }
        [Required(ErrorMessage = "Personel medeni hali bilgisi zorunlu alandır. Boş geçilemez!")]
        public bool EmployeeMarialStatus { get; set; }
        [MaxLength(10)]
        [Required(ErrorMessage = "Personel cinsiyeti zorunlu alandır. Boş geçilemez!")]
        public string EmployeeGender { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "Personel ülke bilgisi zorunlu alandır. Boş geçilemez!")]
        public string EmployeeCountry { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "Personel il bilgisi zorunlu alandır. Boş geçilemez!")]
        public string EmployeeCity { get; set; }
        [MaxLength(20)]
        public string EmployeeStreet { get; set; }
        [MaxLength(20)]
        public string EmployeeBuildNo { get; set; }
        [MaxLength(10)]
        public string EmployeePostcode { get; set; }
        [Required(ErrorMessage = "Personel askerlik tarihi zorunlu alandır. Boş geçilemez!")]
        public DateTime EmployeeMilitaryDate { get; set; }
        [MaxLength(20)]
        [Required(ErrorMessage = "Personel askerlik durumu bilgisi zorunlu alandır. Boş geçilemez!")]
        public string EmployeeMilitaryStatus { get; set; }
        [MaxLength(20)]
        public string EmployeeBankName { get; set; }
        [MaxLength(30)]
        public string EmployeeIban { get; set; }
        [MaxLength(20)]
        public string EmployeeBankCode { get; set; }
        [Required(ErrorMessage = "Personel ehliyet bilgisi zorunlu alandır. Boş geçilemez!")]
        public bool EmployeeIsDrivingLicense { get; set; }
        [MaxLength(20)]
        public string EmployeeDrivingLicenseName { get; set; }
        [MaxLength(250)]
        public string EmployeeImagePath { get; set; }
        [Required(ErrorMessage = "Personel kayıt tarihi zorunlu alandır. Boş geçilemez!")]
        public DateTime EmployeeRegisteredDate { get; set; }
        [MaxLength(100)]
        public string EmployeeWifeNameSurname { get; set; }
        public DateTime EmployeeWifeBirthdate { get; set; }
        [MaxLength(15)]
        public string EmployeeWifeTelephone { get; set; }
        [MaxLength(11)]
        public string EmployeeWifeTCKN { get; set; }
        public DateTime EmployeeSSKFirstBeginDate { get; set; }
        [Required]
        public DateTime EmployeeWorkBeginDate { get; set; }
        public DateTime EmployeeWorkOutDate { get; set; }
        [MaxLength(20)]
        public string EmployeeLanguage1 { get; set; }
        [MaxLength(20)]
        public string EmployeeLanguage2 { get; set; }
        [MaxLength(20)]
        public string EmployeeLanguage3 { get; set; }
        [MaxLength(100)]
        public string EmployeeReferenceNameSurname { get; set; }
        [MaxLength(500)]
        public string EmployeeReferenceNotes { get; set; }
        [MaxLength(15)]
        public string EmployeeReferenceTelephone { get; set; }
        [Required]
        public int EmployeeChildrenCount { get; set; }
        [MaxLength(100)]
        [Required]
        public string EmployeeGraduationSchool { get; set; }
        [MaxLength(50)]
        [Required]
        public string EmployeeGraduationDepartment { get; set; }
        [Required]
        public double EmployeeGraduationScore { get; set; }
        [MaxLength(100)]
        [Required]
        public string EmployeeManager { get; set; }
        [DefaultValue(0)]
        [Required]
        public bool EmployeeDisabilitySituation { get; set; }
        [MaxLength(50)]
        public string EmployeeSGKNumber { get; set; }
        [MaxLength(Int32.MaxValue)]
        public string EmployeeNotes { get; set; }
        [DefaultValue(1)]
        [Required]
        public bool EmployeeStatus { get; set; }
        [DefaultValue(0)]
        [Required]
        public bool EmployeeIsDeleted { get; set; }



        public virtual ICollection<ActivityEmployee> ActivityEmployees { get; set; }
        public virtual Advertisement Advertisement { get; set; }
        public virtual Department Department { get; set; }
        public virtual Branch Branch { get; set; }
        public virtual ICollection<EducationEmployee> EducationEmployees { get; set; }
        public virtual ICollection<AnnouncementEmployee> AnnouncementEmployees { get; set; }
        public virtual IEnumerable<EmployeeRating> EmployeeRating { get; set; }
        public virtual IEnumerable<JobApplication> JobApplication { get; set; }
        public virtual IEnumerable<Log> Log { get; set; }
        public virtual ICollection<EmployeeMessage> EmployeeMessages { get; set; }
        public virtual ICollection<EmployeeMission> EmployeeMissions { get; set; }
        public virtual ICollection<EmployeePermit> EmployeePermits { get; set; }
        public virtual ICollection<EmployeeReference> EmployeeReferences { get; set; }

    }

    public class EmployeeMessage
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int MessageId { get; set; }
        public Message Message { get; set; }
    }
    public class EmployeeMission
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int MissionId { get; set; }
        public Mission Mission { get; set; }
    }
    public class EmployeePermit
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int PermitId { get; set; }
        public Permit Permit { get; set; }
    }
    public class EmployeeReference
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public int ReferenceId { get; set; }
        public Reference Reference { get; set; }
    }

}
