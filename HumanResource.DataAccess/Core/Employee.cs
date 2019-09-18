using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HumanResource.DataAccess.Core
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string Password { get; set; }
        public string Image { get; set; }
        public string CompanyName { get; set; }
        public int BranchID { get; set; }
        public int DepartmentID { get; set; }
        public double GrossFee { get; set; }  //brüt ücret
        public int PersonalCode { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? Birthdate { get; set; }
        public DateTime? WorkBeginDateHR { get; set; }
        public DateTime? WorkBeginDateSGK { get; set; }
        public DateTime? WorkOutDate { get; set; }
        public DateTime? RegisterDate { get; set; }
        public string Job { get; set; }
        public string Mission { get; set; }
        public string Telephone { get; set; }
        public string Phone { get; set; }
        public string BirthPlace { get; set; }
        public string TCKNO { get; set; }
        public string WifeTC { get; set; }
        public string WifeNameSurname { get; set; }
        public string WifeBirthPlace { get; set; }
        public string WifeTelephone { get; set; }
        public string WifeBirthdate { get; set; }
        public string WifeAddress { get; set; }
        public string Y1Closeness { get; set; }
        public string Y1TC { get; set; }
        public string Y1NameSurname { get; set; }
        public string Y1BirthPlace { get; set; }
        public string Y1Telephone { get; set; }
        public string Y1Birthdate { get; set; }
        public string Y1Address { get; set; }
        public string Y2Yakinligi { get; set; }
        public string Y2TC { get; set; }
        public string Y2NameSurname { get; set; }
        public string Y2BirthPlace { get; set; }
        public string Y2Telephone { get; set; }
        public string Y2Birthdate { get; set; }
        public string Y2Address { get; set; }
        public string SSKNo { get; set; }
        public string KanunNo { get; set; }
        public string SosGuvKod { get; set; }  //ssk,emekli sandığı,bağkur,banka ve diğerleri
        public string IseGirisDurumu { get; set; }
        public string IstihdamDurumu { get; set; }
        public string Tahsil { get; set; }
        public DateTime? IlkSSKBaslamaTarihi { get; set; }
        public DateTime? IseGirisTarihi { get; set; }
        public DateTime? KidemTarihi { get; set; }
        public DateTime? IstenAyrilisTarihi { get; set; }
        public string SakatlıkDerecesi { get; set; }
        public string MezunOlduguOkul { get; set; }
        public string MezunOlduğuBolum { get; set; }
        public string TahsilBilgileri { get; set; }
        public string YabasnciDil1 { get; set; }
        public string YabancıDil2 { get; set; }
        public string Notes { get; set; }
        public string BankNo { get; set; }
        public string Iban { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? MilitaryDate { get; set; }
        public string MilitaryStatus { get; set; } //yaptı,yükümsüz,muaf,tecilli
        public bool IsDrivingLicense { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string SpecialCode3 { get; set; }
        public string Postcode { get; set; }
        public string Village { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Street { get; set; }
        public string Avenue { get; set; } //cadde
        public string District { get; set; } //mahalle
        public string Boulevard { get; set; } //bulvar
        public string Gender { get; set; }
        public string BloodGroup { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }







    }
}
