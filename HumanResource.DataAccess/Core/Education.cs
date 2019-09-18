using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Education")]
    public class Education
    {
        [Key]
        public int EducationID { get; set; }
        public string EducationName { get; set; }
        [Required]
        public int NumberOfPeople { get; set; }
        [Required]
        public DateTime BeginDate { get; set; }
        [Required]
        public DateTime EndDate { get; set; }
        public string EducationTime { get; set; }
        public string TrainingInstitution { get; set; }
        [DefaultValue(0)]
        public bool IsDeleted { get; set; }


        public virtual IEnumerable<Employee> Employee { get; set; }
        public virtual IEnumerable<Department> Department { get; set; }
        public virtual IEnumerable<Branch> Branch { get; set; }









    }
}
