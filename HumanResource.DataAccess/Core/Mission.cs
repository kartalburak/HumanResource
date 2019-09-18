using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace HumanResource.DataAccess.Core
{
    [Table("Mission")]
    public class Mission
    {
        [Key]
        public int ID { get; set; }
        public int Status { get; set; }
        public string Missionary { get; set; } //görevi veren
        public string Definition { get; set; }
        public DateTime BeginDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime DeadlineDate { get; set; }
        public int Note { get; set; }
        public string SpecialCode1 { get; set; }
        public string SpecialCode2 { get; set; }
        public string Description { get; set; }
        public bool IsDeleted { get; set; }

        public virtual IEnumerable<Employee> Employee { get; set; }
    }


    enum MissionStatus
    {

        NotInitialize = 0,
        Start = 1,
        Continue = 2,
        Finish = 3

    }
}
