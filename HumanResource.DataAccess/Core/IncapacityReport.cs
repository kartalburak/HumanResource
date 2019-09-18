using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("IncapacityReport")]
    public class IncapacityReport
    {
        [Key]
        public int ID { get; set; }
        public int PersonalID { get; set; }
        public DateTime VisaDate { get; set; }
        public string Hospital { get; set; }
        public string Polyclinic { get; set; }
        public DateTime PolyclinicDate { get; set; }


        public string Diagnostic { get; set; } //teşhis
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime NextControl { get; set; }

        public string Description { get; set; }
        public bool JobAccident { get; set; }
        public bool JobDisease { get; set; }//meslek hastalığı
        public bool Disease { get; set; }
        public bool PeriodicControl { get; set; }
        public string PatientNameSurname { get; set; }
        public string RegistrationNumber { get; set; } //sicil numarası
        public string Diploma { get; set; }
        public string PatentNumber { get; set; } //tescil no
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }







    }
}
